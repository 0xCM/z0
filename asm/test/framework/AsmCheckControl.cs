//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    using static Root;
    
    public interface IAsmCheckControl : IAsmService, IAppMsgSink, IRngProvider
    {
        
    }


    public class AsmCheckCountrol : IAsmCheckControl
    {
        public IAsmContext Context {get;}

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
            => Sink.NotifyConsole(AppMsg.Colorize(content, color));

        public static AsmCheckCountrol Create(IAsmContext context, IAppMsgSink sink, FolderPath root)
            => new AsmCheckCountrol(context.RootedComposition(), sink, root);

        AsmCheckCountrol(IAsmContext context, IAppMsgSink msgsink, FolderPath root)
        {                    
            this.Context = context;
            this.Random = Rng.Pcg64(Seed64.Seed08);
            this.Checks = AsmChecks.Create(context, Random);
            this.Sink = msgsink;
            this.BufferSize = 1024;
            this.BufferCount = 3;
            this.RootPaths = RootEmissionPaths.Define(root);
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


            var index = Checks.IndexApiCode(host, paths.CodePath);                        
                        

            Notify($"Correlated {index.EntryCount} {host} implemented operations with executable code");


            //var hostedBinOps = hosted.KindedOperators(2).ToOpIndex();

            
            






   
        }

    }
}