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

        public ApiHostMemberCode Code(ApiHostUri host, FS.FilePath src)
        {
            var catalog = ApiCatalogs.HostCatalog(Wf, Wf.Api.FindHost(host).Require());
            if(catalog.IsEmpty)
                return ApiHostMemberCode.Empty;
            else
                return new ApiHostMemberCode(host, ApiQuery.index(catalog.Index(), ApiQuery.index(ApiCode.reader(Wf).Read(src))));
        }

        void ExecuteHost(BufferTokens buffers, IApiHost host)
        {
            var src = Wf.Db().ApiHexFile(host.Uri);
            if(!src.Exists)
            {
                Wf.Error($"The host hex file {src} does not exist");
                return;
            }

            var flow = Wf.Running($"Evaluating {host.Uri.Format()}");
            var code = Code(host.Uri, src).Members;

            var count = code.EntryCount;
            if(count == 0)
                Wf.Status($"The host {host.Uri} has no executable members");
            else
            {
                Wf.Status($"Evaluating {count} {host} operations");

                foreach(var api in code.UnaryOperators)
                    Dispatcher.Dispatch(buffers, api, OperatorClasses.unary());

                foreach(var api in code.BinaryOperators)
                    Dispatcher.Dispatch(buffers, api, OperatorClasses.binary());
            }

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

        public void Execute(params PartId[] parts)
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