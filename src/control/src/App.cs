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
            // using var wf = new WfContext(Context, Flow.config(Context, Flow.TermReceiver), Flow.TermReceiver);
            // using var host = new CaptureHost(ContextFactory.CreateAsmContext(Context), PartWf.configure(wf, args));
            // host.Consolidate();
        }

        public static void Main(params string[] args)
            => Launch(args);
    }

    public static partial class XTend { }
}