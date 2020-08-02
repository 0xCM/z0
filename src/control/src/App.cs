//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    class App : AppShell<App,IAppContext>
    {                
        public App()
            : base(ContextFactory.CreateAppContext())
        {

        }
        
        public override void RunShell(params string[] args)
        {                        
            using var wf = new WfContext(Context, Flow.config(Context, Flow.TermReceiver), Flow.TermReceiver);
            var config = PartWf.configure(wf, args);
            var parts = config.Parts;
            if(parts.Length != 0)
            {
                var msg = text.format("Running capture workflow: {0}", parts.Format());
                term.print(msg);

                var context = ContextFactory.CreateAsmContext(Context);
                using var host = new CaptureHost(context, config);
                host.Consolidate();

            }
            else
            {
                term.print("It seems there is no work to be done");
            }
        }

        public static void Main(params string[] args)
            => Launch(args);
    }

    public static partial class XTend { }
}