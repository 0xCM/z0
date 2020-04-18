//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using K = Kinds;
    
    using static Seed;
    using static Memories;

    public class EvalWorkflow : IEvalWorkflow
    {
        readonly IApiContext Context;
        
        readonly IEvalDispatcher Dispatcher;
        
        readonly ByteSize BufferSize;

        readonly int BufferCount;

        readonly ICaptureArchive CodeArchive;

        readonly IApiSet ApiSet;
                
        public static EvalWorkflow Create(IApiContext context, IPolyrand random, FolderPath root)
            => new EvalWorkflow(context, random, root);

        EvalWorkflow(IApiContext context, IPolyrand random, FolderPath root)
        {                    
            this.Context = context;
            this.Dispatcher = EvalDispatcher.Create(random, context);
            this.BufferSize = 1024;
            this.BufferCount = 3;
            this.CodeArchive = CaptureArchive.Create(root);
            this.ApiSet = context;
        }
                
        void ExecuteHost(in BufferSeq buffers, IApiHost host)
        {
            var dst = CodeArchive.HostArchive(host.UriPath);
            if(dst.HexPath.Exists())
            {
                var apiIndex = Context.ApiCodeIndex(ApiSet, host.UriPath, CodeArchive.RootDir);
                Context.Notify($"Correlated {apiIndex.EntryCount} {host} implemented operations with executable code");

                foreach(var api in apiIndex.BinaryOperators)
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
        
        public void Execute(params string[] args)
        {
            using var buffers = BufferSeq.alloc(BufferSize, BufferCount);

            Context.Notify($"{BufferCount} buffers of length {BufferSize} successfully allocated");
            var catalogs = ApiSet.Composition.Catalogs;
            iter(catalogs,ExecuteCatalog);
        }
    }
}