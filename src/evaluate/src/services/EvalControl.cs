//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;

    public class EvalControl : IEvalControl
    {
        readonly IWfShell Wf;

        readonly byte BufferCount;

        readonly uint BufferSize;

        readonly IEvalDispatcher Dispatcher;

        readonly IPartCapturePaths CodeArchive;

        readonly IGlobalApiCatalog ApiGlobal;

        internal EvalControl(IWfShell wf, IPolyrand random, FS.FolderPath root, uint buffersize)
        {
            Wf = wf;
            BufferCount = 3;
            BufferSize = buffersize;
            Dispatcher = Evaluate.dispatcher(Wf, random, BufferSize);
            CodeArchive = Archives.capture(root);
            ApiGlobal = wf.Api;
        }

        [Op]
        public static ApiHostMemberCode code(IWfShell wf, ApiHostUri host, FS.FolderPath root)
        {
            var catalog = ApiCatalogs.host(wf, wf.Api.FindHost(host).Require());
            if(catalog.IsEmpty)
                return ApiHostMemberCode.Empty;

            var idx = catalog.Index();
            var archive =  Archives.capture(root);
            var paths =  Archives.capture(FS.dir(root.Name), host);
            var code = ApiExtractReader.Service.Read(paths.HostHexPath);
            var opIndex =  ApiQuery.index(code);
            return new ApiHostMemberCode(host, ApiQuery.index(idx, opIndex));
        }

        void ExecuteHost(BufferTokens buffers, IApiHost host)
        {
            var capture = Archives.capture(FS.dir(CodeArchive.Root.Name), host.Uri);
            if(capture.HostHexPath.Exists)
            {

                var code = EvalControl.code(Wf, host.Uri, CodeArchive.Root).Members;
                Wf.Status($"Correlated {code.EntryCount} {host} implemented operations with executable code");

                foreach(var api in code.UnaryOperators)
                    Dispatcher.Dispatch(buffers, api, OperatorClasses.unary());

                foreach(var api in code.BinaryOperators)
                    Dispatcher.Dispatch(buffers, api, OperatorClasses.binary());
            }
        }

        void ExecuteCatalog(IApiPartCatalog catalog)
        {
            using var buffers = Buffers.sequence(BufferSize, BufferCount);
            foreach(var host in catalog.OperationHosts)
                ExecuteHost(buffers.Tokenize(), host);
        }

        public void Execute(params PartId[] parts)
        {
            using var buffers = Buffers.sequence(BufferSize, BufferCount);
            iter(ApiGlobal.PartCatalogs(parts), ExecuteCatalog);
        }
    }
}