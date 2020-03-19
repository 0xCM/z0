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
    
    using C = OpClasses;
    using Reps = OpClassReps;
    

    using static Root;    

    class AsmExecWorkflow : IAsmExecWorkflow
    {
        public IAsmWorkflowContext Context {get;}

        public IPolyrand Random {get;}

        IAppMsgSink Sink {get;}
        
        AsmChecks Checks {get;}

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
            this.Random = Rng.Pcg64(Seed64.Seed08);
            this.Sink = msgsink;
            this.Context = AsmWorkflowContext.Rooted(context, Random);
            this.Checks = AsmChecks.Create(Context, msgsink);
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
        public IEnumerable<HostedMember> HostedMembers(in ApiHostUri host)
            => Context.FindHost(host).MapRequired(host => Context.MemberLocator().Hosted(host));

        OpIndex<HostedMember> HostMemberIndex(ApiHostUri host)
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
        

        public void Run()
        {
            using var buffers = BufferSeq.alloc(BufferSize, BufferCount);

            Notify($"{BufferCount} buffers of length {BufferSize} successfully allocated");

            var host = ApiHostUri.FromHost(typeof(math));
            var paths = HostPaths(host);
            
            var apiIndex = Correlator.CreateApiIndex(HostMemberIndex(host), HostCodeIndex(host));

            Notify($"Correlated {apiIndex.EntryCount} {host} implemented operations with executable code");

            var selected = apiIndex.KindedOperators(2).ToArray();

            Notify($"Found {selected.Length} {host} kinded binary operarators");

            var messages = list<AppMsg>(selected.Length);        
            
            // foreach(var api in selected)
            // {
            //     var uri = api.Uri;
            //     var oc = OperatorTypeClass.Infer(api.Method).Format();
            //     var kind = api.Method.KindId().Format();
            //     messages.Add(AppMsg.NoCaller(text.concat(uri.Identifier.PadRight(90), text.spaced(text.pipe()), kind.ToString().PadRight(14), oc), AppMsgKind.Info));
            // }            

            
            
            foreach(var api in selected)
            {
                var uri = api.Uri;
                var oc = OperatorTypeClass.Infer(api.Method).Format();
                var kind = api.Method.KindId().Format();
                messages.Add(AppMsg.NoCaller(text.concat(uri.Identifier.PadRight(90), text.spaced(text.pipe()), kind.ToString().PadRight(14), oc), AppMsgKind.Info));
                Dispatch(buffers, api, default(C.BinaryOp));
            }
            
            //Checks.Execute(buffers, selected);            

            using var log = OpenLog("kinded-binary-ops", FileExtensions.Csv, FileWriteMode.Append);
            log.Write(messages.ToArray());

        }

        void Analyze<T>(in ApiMemberCode api,  in PairEval<T> eval)
            where T : unmanaged
        {
            var name = api.Member.Id.Name;
            var count = math.min(eval.Source.Count,10);
            NotifyConsole(api.Uri);

            for(var i=0; i<count; i++)
            {
                var input = eval.Source[i];
                var result = eval.Target[i];
                NotifyConsole($"{name}{input} = {result.Third}");
            }
        }

        void Dispatch(in BufferSeq buffers, in ApiMemberCode api, C.BinaryOp @class)
        {
            var kid = api.Member.KindId;
            int count = 128;
            if(kid == 0 || kid == OpKindId.Div || kid == OpKindId.Mod)
                return;

            var nk = api.Method.ReturnType.NumericKind();

            switch(nk)
            {
                case NumericKind.U8:
                    Analyze(api,Context.Evaluate(buffers, api, Reps.binaryOp<byte>()));
                    break;
                case NumericKind.I8:
                    Analyze(api,Context.Evaluate(buffers, api, Reps.binaryOp<sbyte>()));
                    break;
                case NumericKind.I16:
                    Analyze(api,Context.Evaluate(buffers, api, Reps.binaryOp<short>()));
                    break;
                case NumericKind.U16:
                    Analyze(api,Context.Evaluate(buffers, api, Reps.binaryOp<ushort>()));
                    break;
                case NumericKind.I32:
                    Analyze(api,Context.Evaluate(buffers, api, Reps.binaryOp<int>()));
                    break;
                case NumericKind.U32:
                    Analyze(api,Context.Evaluate(buffers, api, Reps.binaryOp<uint>()));
                    break;
                case NumericKind.I64:
                    Analyze(api,Context.Evaluate(buffers, api, Reps.binaryOp<long>()));
                    break;
                case NumericKind.U64:
                    Analyze(api,Context.Evaluate(buffers, api, Reps.binaryOp<ulong>()));
                    break;
                default:
                    break;
            }            
        }
    }
}