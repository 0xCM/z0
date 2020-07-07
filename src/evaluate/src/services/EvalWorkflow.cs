//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using K = Kinds;
    
    using static Konst;
    using static Memories;

    public class EvalWorkflow : IEvalWorkflow
    {
        readonly IAppContext Context;
        
        readonly IEvalDispatcher Dispatcher;
        
        readonly uint BufferSize;

        readonly byte BufferCount;

        readonly TCaptureArchive CodeArchive;

        readonly IApiSet ApiSet;
                
        internal EvalWorkflow(IAppContext context, IPolyrand random, FolderPath root, uint buffersize)
        {                    
            BufferCount = 3;
            BufferSize = buffersize;
            Context = context;
            Dispatcher = Evaluate.dispatcher(random, context, buffersize);
            CodeArchive = Archives.Services.CaptureArchive(root);
            ApiSet = context;
        }
                
        void ExecuteHost(BufferTokens buffers, IApiHost host)
        {
            var dst = CodeArchive.HostArchive(host.Uri);
            if(dst.HexPath.Exists)
            {
                var code = ApiIndexBuilder.create(Identities.Services.ApiLocator, ApiSet, host.Uri, CodeArchive.ArchiveRoot);
                Context.Notify($"Correlated {code.EntryCount} {host} implemented operations with executable code");

                foreach(var api in code.UnaryOperators)
                    Dispatcher.Dispatch(buffers, api, K.UnaryOp);

                foreach(var api in code.BinaryOperators)
                    Dispatcher.Dispatch(buffers, api, K.BinaryOp);
            }
        }

        void ExecuteCatalog(IApiCatalog catalog)
        {
            using var buffers = Buffers.sequence(BufferSize, BufferCount);
            
            foreach(var host in catalog.Hosts)
            {
                ExecuteHost(buffers.Tokenize(), host);
            }
        }
        
        public void Execute(params PartId[] parts)
        {
            using var buffers = Buffers.sequence(BufferSize, BufferCount);
            iter(ApiSet.MatchingCatalogs(parts), ExecuteCatalog);
        }
    }
}