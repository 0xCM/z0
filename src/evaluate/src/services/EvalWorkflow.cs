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
                
        public static EvalWorkflow Create(IAppContext context, IPolyrand random, FolderPath root)
            => new EvalWorkflow(context, random, root);

        internal EvalWorkflow(IAppContext context, IPolyrand random, FolderPath root)
        {                    
            this.Context = context;
            this.Dispatcher = EvalDispatcher.Create(random, context);
            this.BufferSize = 1024;
            this.BufferCount = 3;
            this.CodeArchive = Archives.Services.CaptureArchive(root);
            this.ApiSet = context;
        }
                
        void ExecuteHost(in BufferSeq buffers, IApiHost host)
        {
            var dst = CodeArchive.CaptureArchive(host.UriPath);
            if(dst.HexPath.Exists())
            {
                var code = ArchiveOps.Service.CreateCodeIndex(StatelessIdentity.Services.MemberLocator(), ApiSet, host.UriPath, CodeArchive.RootDir);
                Context.Notify($"Correlated {code.EntryCount} {host} implemented operations with executable code");

                foreach(var api in code.BinaryOperators)
                {
                    var uri = api.Uri;
                    var oc = OperatorTypeClass.Infer(api.Method).Format();
                    var kind = api.Method.KindId().Format();
                    var ok = default(K.BinaryOpClass);
                    Dispatcher.Dispatch(buffers, api, ok);
                }
            }
        }

        void ExecuteCatalog(IApiCatalog catalog)
        {
            using var buffers = BufferSeq.alloc(BufferSize, BufferCount);
            
            foreach(var host in catalog.ApiHosts)
            {
                ExecuteHost(buffers, host);
            }
        }
        
        public void Execute(params PartId[] parts)
        {
            using var buffers = BufferSeq.alloc(BufferSize, BufferCount);
            iter(ApiSet.MatchingCatalogs(parts), ExecuteCatalog);
        }
    }
}