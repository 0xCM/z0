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

    class AsmExecWorkflow : IAsmExecWorkflow
    {
        readonly IAsmContext Context;

        readonly IAppMsgSink Sink;
        
        readonly IEvalDispatcher Dispatcher;
        
        readonly ByteSize BufferSize;

        readonly int BufferCount;

        readonly RootEmissionPaths RootPaths;

        readonly IApiCodeIndexer CodeIndexer;

        readonly IApiSet ApiSet;
        
        public static AsmExecWorkflow Create(IAsmContext context, IAppMsgSink sink, FolderPath root)
            => new AsmExecWorkflow(context, sink, root);

        AsmExecWorkflow(IAsmContext context, IAppMsgSink msgsink, FolderPath root)
        {                    
            this.Sink = msgsink;
            this.Context = context;
            this.Dispatcher = EvalDispatcher.Create(context, msgsink, context.Random);
            this.BufferSize = 1024;
            this.BufferCount = 3;
            this.RootPaths = RootEmissionPaths.Define(root);
            this.ApiSet = Context.ApiSet;
            this.CodeIndexer = context.CodeIndexer(ApiSet);
        }

        HostEmissionPaths HostPaths(in ApiHostUri host)
            => RootPaths.HostPaths(host);
        
        void Notify(string msg, AppMsgKind? severity = null)
            => Sink.Notify(msg, severity);
        
        void Notify(AppMsg msg)
            => Sink.Deposit(msg);

        void NotifyConsole(AppMsg msg)
            => Sink.NotifyConsole(msg);

        void NotifyConsole(object content, AppMsgColor color = AppMsgColor.Green)
            => Sink.NotifyConsole(content, color);
        
        void ExecuteHost(in BufferSeq buffers, in ApiHost host)
        {
            var paths = HostPaths(host);
            if(paths.CodePath.Exists())
            {

                var apiIndex = Context.ApiCodeIndex(ApiSet, host, RootPaths.RootDir);
                Notify($"Correlated {apiIndex.EntryCount} {host} implemented operations with executable code");

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

            Notify($"{BufferCount} buffers of length {BufferSize} successfully allocated");
            var catalogs = ApiSet.Composition.Catalogs;
            iter(catalogs,ExecuteCatalog);
        }
    }
}