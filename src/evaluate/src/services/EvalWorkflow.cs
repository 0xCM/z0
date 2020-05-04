//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    using K = Kinds;
    
    using static Seed;
    using static Memories;

    public class EvalWorkflow : IEvalWorkflow
    {
        readonly IAppContext Context;
        
        readonly IEvalDispatcher Dispatcher;
        
        readonly ByteSize BufferSize;

        readonly int BufferCount;

        readonly ICaptureArchive CodeArchive;

        readonly IApiSet ApiSet;
                
        public static IEvalWorkflow Create(IAppContext context, IPolyrand random, FolderPath root)
            => new EvalWorkflow(context, random, root);

        internal EvalWorkflow(IAppContext context, IPolyrand random, FolderPath root)
        {                    
            Context = context;
            Dispatcher = EvalDispatcher.Create(random, context);
            BufferSize = 1024;
            BufferCount = 3;
            CodeArchive = Archives.Services.CaptureArchive(root);
            ApiSet = context;
        }
                
        void ExecuteHost(BufferTokens buffers, IApiHost host)
        {
            var dst = CodeArchive.HostArchive(host.UriPath);
            if(dst.HexPath.Exists())
            {
                var code = ArchiveOps.Service.CreateCodeIndex(Identities.Services.ApiLocator, ApiSet, host.UriPath, CodeArchive.RootDir);
                Context.Notify($"Correlated {code.EntryCount} {host} implemented operations with executable code");

                foreach(var api in code.UnaryOperators)
                    Dispatcher.Dispatch(buffers, api, K.UnaryOp);

                foreach(var api in code.BinaryOperators)
                    Dispatcher.Dispatch(buffers, api, K.BinaryOp);
            }
        }

        void ExecuteCatalog(IApiCatalog catalog)
        {
            using var buffers = BufferSeq.alloc(BufferSize, BufferCount);
            
            foreach(var host in catalog.ApiHosts)
            {
                ExecuteHost(buffers.Tokenize(), host);
            }
        }
        
        public void Execute(params PartId[] parts)
        {
            using var buffers = BufferSeq.alloc(BufferSize, BufferCount);
            iter(ApiSet.MatchingCatalogs(parts), ExecuteCatalog);
        }
    }
}