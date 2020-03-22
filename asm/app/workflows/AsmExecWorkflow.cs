//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    using C = Classes;
    
    using static Root;    

    class AsmExecWorkflow : IAsmExecWorkflow
    {
        public IAsmContext Context {get;}

        IAppMsgSink Sink {get;}
        
        IAsmEvalDispatcher Dispatcher {get;}
        
        ByteSize BufferSize {get;}

        int BufferCount {get;}

        RootEmissionPaths RootPaths {get;}
        
        HostEmissionPaths HostPaths(in ApiHostUri host)
            => RootPaths.HostPaths(host);
        
        public void Notify(string msg, AppMsgKind? severity = null)
            => Sink.Notify(msg, severity);
        
        public void Notify(AppMsg msg)
            => Sink.Notify(msg);

        public void NotifyConsole(AppMsg msg)
            => Sink.NotifyConsole(msg);

        public void NotifyConsole(object content, AppMsgColor color = AppMsgColor.Green)
            => Sink.NotifyConsole(content, color);

        public static AsmExecWorkflow Create(IAsmContext context, IAppMsgSink sink, FolderPath root)
            => new AsmExecWorkflow(context, sink, root);

        AsmExecWorkflow(IAsmContext context, IAppMsgSink msgsink, FolderPath root)
        {                    
            this.Sink = msgsink;
            this.Context = context;
            this.Dispatcher = AsmEvalDispatcher.Create(Context, msgsink);
            this.BufferSize = 1024;
            this.BufferCount = 3;
            this.RootPaths = RootEmissionPaths.Define(root);
        }

        ILogDevice OpenLog(string name, FileExtension ext = null, FileWriteMode mode = FileWriteMode.Overwrite,  bool display = false)
        {
            var target = RootPaths.LogDir + FileName.Define(name, ext ?? FileExtensions.Log);
            return Context.OpenLogDevice(target, name, mode, display);
        }

        /// <summary>
        /// Reads code from a hex file
        /// </summary>
        /// <param name="src">The source path</param>
        public ReadOnlySpan<AsmOpBits> LoadCode(FilePath src)
            => Context.HexReader().Read(src).ToArray();

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        public IEnumerable<ApiStatelessMember> HostedMembers(in ApiHostUri host)
            => Context.FindHost(host).MapRequired(host => Context.MemberLocator().Hosted(host));

        OpIndex<ApiStatelessMember> HostMemberIndex(ApiHostUri host)
        {
            var hosted = HostedMembers(host);
            var index = hosted.ToOpIndex();
            Notify($"Found {index.EntryCount} members hosted by {host}");
            return index;
        }

        OpIndex<AsmOpBits> HostCodeIndex(ApiHostUri host)
        {
            var paths = HostPaths(host);
            var code = LoadCode(paths.CodePath);
            var index = code.ToEnumerable().ToOpIndex();    
            Notify($"Found {index.EntryCount} encoded functions emitted fo {host}");
            return index;
        }

        IApiCorrelator Correlator
            => Context.ApiCorrelator();
        
        void ExecuteHost(in BufferSeq buffers, in ApiHost host)
        {
            var paths = HostPaths(host);
            if(paths.CodePath.Exists())
            {
                var apiIndex = Correlator.CreateApiIndex(HostMemberIndex(host), HostCodeIndex(host));
                Notify($"Correlated {apiIndex.EntryCount} {host} implemented operations with executable code");

                foreach(var api in apiIndex.BinaryOperators)
                {
                    var uri = api.Uri;
                    var oc = OperatorTypeClass.Infer(api.Method).Format();
                    var kind = api.Method.KindId().Format();
                    var ok = default(C.BinaryOp);
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
        public void Run()
        {
            using var buffers = BufferSeq.alloc(BufferSize, BufferCount);

            Notify($"{BufferCount} buffers of length {BufferSize} successfully allocated");
            var catalogs = Context.Compostion.Catalogs;
            iter(catalogs,ExecuteCatalog);


            // var host = ApiHostUri.FromHost(typeof(math));
            // var paths = HostPaths(host);
            // var apiIndex = Correlator.CreateApiIndex(HostMemberIndex(host), HostCodeIndex(host));

            //Notify($"Correlated {apiIndex.EntryCount} {host} implemented operations with executable code");

            // var selected = apiIndex.BinaryOperators;

            // Notify($"Found {selected.Length} {host} kinded binary operarators");

            // var messages = list<AppMsg>(selected.Length);        


            // foreach(var api in selected)
            // {
            //     var uri = api.Uri;
            //     var oc = OperatorTypeClass.Infer(api.Method).Format();
            //     var kind = api.Method.KindId().Format();
            //     var ok = default(C.BinaryOp);
            //     messages.Add(AppMsg.NoCaller(text.concat(uri.Identifier.PadRight(90), text.spaced(text.pipe()), kind.ToString().PadRight(14), oc), AppMsgKind.Info));
            //     Dispatcher.Dispatch(buffers, api, ok);
            // }
            
            // using var log = OpenLog("kinded-binary-ops", FileExtensions.Csv, FileWriteMode.Append);
            // log.Write(messages.ToArray());
        }

    }
}