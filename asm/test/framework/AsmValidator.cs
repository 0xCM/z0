//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Validation
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    using static Root;    

    class AsmValidator : IAsmValidator
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

        public static AsmValidator Create(IAsmContext context, IAppMsgSink sink, FolderPath root)
            => new AsmValidator(context.RootedComposition(), sink, root);

        AsmValidator(IAsmContext context, IAppMsgSink msgsink, FolderPath root)
        {                    
            this.Random = Rng.Pcg64(Seed64.Seed08);
            this.Sink = msgsink;
            this.Context = AsmWorkflowContext.Rooted(context, Random);
            this.Checks = AsmChecks.Create(Context, msgsink);
            this.BufferSize = 1024;
            this.BufferCount = 3;
            this.RootPaths = RootEmissionPaths.Define(root);
        }

        ILogDevice OpenLog(string name, FileExtension ext = null, OverwriteOption? overwrite = null,  bool display = false)
        {
            var target = RootPaths.LogDir + FileName.Define(name, ext ?? FileExtensions.Log);
            var append = (overwrite ?? OverwriteOption.Overwrite) == OverwriteOption.Append;
            return Context.OpenLogDevice(target, name, append, display);
        }

        public void CheckAsm()
        {
            using var buffers = BufferSeq.alloc(BufferSize, BufferCount);

            Notify($"{BufferCount} buffers of length {BufferSize} successfully allocated");

            var host = ApiHostUri.FromHost(typeof(math));
            var paths = HostPaths(host);
            var code = Checks.LoadCode(paths.CodePath);
            var codeIndex = code.ToEnumerable().ToOpIndex();
            
            Notify($"Found {code.Length} {host} operations from code persisted in {paths.CodePath}");

            var hosted = Checks.HostedMembers(host);
            var hostedIndex = hosted.ToOpIndex();
            

            Notify($"Found {hostedIndex.EntryCount} {host} operations defined by the implementation type");

            var correlator = Context.ApiCorrelator();
            var index = correlator.IndexMemberCode(host, paths.CodePath);                        
                        

            Notify($"Correlated {index.EntryCount} {host} implemented operations with executable code");


            var kinded = index.KindedOperators(2).ToArray();

            Notify($"Found {kinded.Length} {host} kinded binary operarators");


            var messages = list<AppMsg>(kinded.Length);        
            foreach(var k in kinded)
            {
                var uri = k.Uri;
                var oc = k.Method.ClassifyTypedOperator().Format();
                var kind = k.Method.KindId().Format();
                messages.Add(AppMsg.NoCaller(text.concat(uri.Identifier.PadRight(90), text.spaced(text.pipe()), kind.ToString().PadRight(14), oc), AppMsgKind.Info));
            }
            

            using var log = OpenLog("kinded-binary-ops", FileExtensions.Csv, OverwriteOption.Append);
            log.Write(messages.ToArray());

            
            foreach(var c in kinded)
            {
                Checks.CheckExecution(c);
            }

   
        }

    }
}