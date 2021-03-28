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

        readonly IApiCatalogDataset ApiGlobal;

        internal EvalControl(IWfShell wf, IDomainSource source, FS.FolderPath root, uint buffersize)
        {
            Wf = wf;
            BufferCount = 3;
            BufferSize = buffersize;
            Dispatcher = Wf.EvalDispatcher(source, BufferSize);
            ApiGlobal = wf.Api;
        }

        void ExecuteHost(BufferTokens buffers, ApiHostUri host)
        {
            var src = Wf.Db().ApiHexFile(host);
            if(!src.Exists)
                return;

            var services = Wf.ApiServices();
            var flow = Wf.Running($"Running {host.Format()} evaluaton workflow");
            var catalog = services.HostCatalog(Wf.Api.FindHost(host).Require());
            if(catalog.IsEmpty)
                return;

            var members = ApiIndex.create(catalog);
            Wf.Status($"Indexed {members.EntryCount} {host} members");

            var blocks = ApiHex.reader(Wf).Read(src);
            Wf.Status($"Read {blocks.Count} {host} operations from {src}");

            var api = Wf.ApiServices();
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
            using var buffers = NativeBuffers.alloc(BufferSize, BufferCount);
            foreach(var host in catalog.OperationHosts)
                ExecuteHost(buffers.Tokenize(), host.Uri);
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
                using var buffers = NativeBuffers.alloc(BufferSize, BufferCount);
                for(var i=0; i<count; i++)
                    ExecuteCatalog(memory.skip(catalogs,i));

                root.iter(ApiGlobal.PartCatalogs(parts), ExecuteCatalog);
            }
        }
    }
}