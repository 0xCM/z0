//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;


    ref struct Runner
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly IAsmContext Context;

        public Runner(IWfShell wf, WfHost host, IAsmContext context)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Context = context;
        }

        public void Dispose()
        {

        }

        public void Run()
        {
        }
    }

    sealed class App : WfHost<App>
    {
        readonly IAsmContext Context;

        public App()
        {

        }
        protected override void Execute(IWfShell wf)
        {
            using var runner = new Runner(wf,this,Context);
            runner.Run();
        }

        App(IAsmContext context)
        {
            Context = context;
        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = Polyrand.install(WfShell.create(args));
                var host = new App(new AsmContext(Apps.context(wf), wf));
                host.Run(wf);

            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
    }

    public static partial class XTend { }
}