//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    sealed class App : WfHost<App>
    {
        public App()
        {

        }

        public static void Main(params string[] args)
        {
            try
            {
                var cmd1 = new CmdLine("cmd /c dir j:\\");
                var cmd2 = new CmdLine("llvm-mc --help");

                using var wf = WfShell.create(args).WithRandom(Rng.@default());
                var process = Cmd.process(wf,cmd2).Wait();
                var output = process.Output;
                wf.Status(output);

                //create().Run(wf);
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        protected override void Execute(IWfShell wf)
        {
            using var runner = new Dynoshell(wf);
            runner.Run();
        }
    }

    public static partial class XTend { }
}