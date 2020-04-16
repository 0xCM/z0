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

    class EvalWorkflow : IEvalWorkflow
    {
        readonly IContext Context;

        readonly IAppMsgSink Sink;
        
        readonly IEvalDispatcher Dispatcher;
        
        readonly ByteSize BufferSize;

        readonly int BufferCount;

        readonly IApiCodeArchive CodeArchive;

        readonly IApiSet ApiSet;
        
        public static EvalWorkflow Create(IAsmContext context, IAppMsgSink sink, FolderPath root)
            => new EvalWorkflow(context, sink, root);

        EvalWorkflow(IAsmContext context, IAppMsgSink msgsink, FolderPath root)
        {                    
            this.Context = context;
            this.Sink = msgsink;
            this.Dispatcher = EvalDispatcher.Create(context.Random, msgsink);
            this.BufferSize = 1024;
            this.BufferCount = 3;
            this.CodeArchive = ApiCodeArchive.Define(root);
            this.ApiSet = context.ApiSet;
        }
                
        void ExecuteHost(in BufferSeq buffers, IApiHost host)
        {
            var dst = CodeArchive.HostArchive(host.UriPath);
            if(dst.HexPath.Exists())
            {
                var apiIndex = Context.ApiCodeIndex(ApiSet, host.UriPath, CodeArchive.RootDir);
                Sink.Notify($"Correlated {apiIndex.EntryCount} {host} implemented operations with executable code");

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

            Sink.Notify($"{BufferCount} buffers of length {BufferSize} successfully allocated");
            var catalogs = ApiSet.Composition.Catalogs;
            iter(catalogs,ExecuteCatalog);
        }
    }
}