//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    sealed class AppRunner : WfHost<AppRunner>
    {
        public AppRunner()
        {

        }

        public void Dispose()
        {

        }

        protected override void Execute(IWfShell wf)
        {
            using var flow = wf.Running();
            zfunc.iter(wf.Args, arg => wf.Row(arg));
        }
    }

    class App : IDisposable
    {
        readonly IWfShell Wf;

        App(IWfShell wf)
            => Wf = wf;

        public void Dispose()
        {
        }

        public void Run()
            => new AppRunner().Run(Wf);


        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfShell.create(args);
                using var runner = new App(wf);
                runner.Run();
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
    }
}