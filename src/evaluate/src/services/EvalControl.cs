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
        readonly IAppContext Context;

        readonly IEvalDispatcher Dispatcher;

        readonly uint BufferSize;

        readonly byte BufferCount;

        readonly IPartCapturePaths CodeArchive;

        readonly ISystemApiCatalog ApiSet;

        internal EvalControl(IAppContext context, IPolyrand random, FS.FolderPath root, uint buffersize)
        {
            BufferCount = 3;
            BufferSize = buffersize;
            Context = context;
            Dispatcher = Evaluate.dispatcher(random, context, buffersize);
            CodeArchive = Archives.capture(root);
            ApiSet = context.Api;
        }

        void ExecuteHost(BufferTokens buffers, IApiHost host)
        {
            var dst = Archives.capture(FS.dir(CodeArchive.Root.Name), host.Uri);
            if(dst.HostX86Path.Exists)
            {
                var code = ApiQuery.code(ApiSet, host.Uri, CodeArchive.Root).Members;
                Context.Notify($"Correlated {code.EntryCount} {host} implemented operations with executable code");

                foreach(var api in code.UnaryOperators)
                    Dispatcher.Dispatch(buffers, api, Api.unary());

                foreach(var api in code.BinaryOperators)
                    Dispatcher.Dispatch(buffers, api, Api.binary());
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
            iter(ApiSet.PartCatalogs(parts), ExecuteCatalog);
        }
    }
}