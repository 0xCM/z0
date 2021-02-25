//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class EvalControl : IEvalControl
    {
        readonly IWfShell Wf;

        readonly byte BufferCount;

        readonly uint BufferSize;

        readonly IEvalDispatcher Dispatcher;

        readonly IGlobalApiCatalog ApiGlobal;

        internal EvalControl(IWfShell wf, IPolyrand random, FS.FolderPath root, uint buffersize)
        {
            Wf = wf;
            BufferCount = 3;
            BufferSize = buffersize;
            Dispatcher = Evaluate.dispatcher(Wf, random, BufferSize);
            ApiGlobal = wf.Api;
        }

        void ExecuteHost(BufferTokens buffers, ApiHostUri host)
        {
            var src = Wf.Db().ApiHexFile(host);
            if(!src.Exists)
                return;

            var flow = Wf.Running($"Running {host.Format()} evaluaton workflow");
            var catalog = ApiRuntime.catalog(Wf, Wf.Api.FindHost(host).Require());
            if(catalog.IsEmpty)
                return;

            var members = ApiIndex.create(catalog);
            Wf.Status($"Indexed {members.EntryCount} {host} members");

            var blocks = ApiCode.reader(Wf).Read(src);
            Wf.Status($"Read {blocks.Count} {host} operations from {src}");

            var api = Wf.ApiServices();
            //var correlated = api.Correlate(catalog, blocks);
            //Wf.Status($"Correlated {correlated.Count} members with executable code");

            //correlate(catalog.Members, blocks);

            var operations = ApiIndex.create(blocks);
            Wf.Status($"Hydrated {operations.EntryCount} {host} operations from {blocks.Count} blocks");

            var identities =  members.Keys.ToHashSet();
            identities.IntersectWith(operations.Keys);

            Wf.Status($"Found {identities.Count} common operation identifiers");

            // var joined = ApiIndex.join(members,operations);
            // Wf.Status($"Joined {joined.Count} members with executable code");

            // var code = ops.CreateIndex(members, operations);
            // var count = code.EntryCount;

            // Wf.Status($"Created code index with {count} members");

            // if(count != 0)
            // {
            //     Wf.Status($"Evaluating {count} {host} operations");

            //     foreach(var api in code.UnaryOperators)
            //         Dispatcher.Dispatch(buffers, api, OperatorClasses.unary());

            //     foreach(var api in code.BinaryOperators)
            //         Dispatcher.Dispatch(buffers, api, OperatorClasses.binary());
            // }

            Wf.Ran(flow);
        }

        void ExecuteCatalog(IApiPartCatalog catalog)
        {
            var flow = Wf.Running($"Evaluating {catalog.PartId.Format()}");
            using var buffers = Buffers.sequence(BufferSize, BufferCount);
            foreach(var host in catalog.OperationHosts)
                ExecuteHost(buffers.Tokenize(), host);
            Wf.Ran(flow);
        }

        bool Enabled => false;

        public void Execute(params PartId[] parts)
        {
            if(Enabled)
            {

                var catalogs = ApiGlobal.PartCatalogs(parts).View;
                var count = catalogs.Length;
                var flow = Wf.Running($"Evaluating {count} parts");
                using var buffers = Buffers.sequence(BufferSize, BufferCount);
                for(var i=0; i<count; i++)
                    ExecuteCatalog(memory.skip(catalogs,i));

                root.iter(ApiGlobal.PartCatalogs(parts), ExecuteCatalog);
            }
        }
    }
}