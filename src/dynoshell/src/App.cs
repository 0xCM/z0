//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;

    using Z0.Tools;

    using static Tools.Llvm;

    sealed class App : WfHost<App>
    {
        public App()
        {

        }

        public static void run(IWfShell wf, CmdLine cmd)
        {
            var process = Cmd.process(wf, cmd).Wait();
            var output = process.Output;
            wf.Status(output);
        }

        public static void show(IWfShell wf, CmdLine cmd)
        {
            wf.Status(cmd.Format());
        }

        static void TestCmdLine(params string[] args)
        {
            var cmd1 = new CmdLine("cmd /c dir j:\\");
            var cmd2 = new CmdLine("llvm-mc --help");
            using var wf = WfShell.create(args).WithRandom(Rng.@default());
            var process = Cmd.process(wf,cmd2).Wait();
            var output = process.Output;
            wf.Status(output);
        }


        static void RunInterpreter(IWfShell wf)
        {
            var cmd = WinCmdShell.create(wf);
            cmd.Submit("dir J:\\");
            cmd.Run();
            cmd.WaitForExit();
        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfShell.create(args).WithRandom(Rng.@default());
                var llvm = Llvm.service(wf);
                var paths = llvm.Paths();
                var cases = paths.Test.ModuleDir(ModuleNames.Analysis, TestSubjects.AliasSet);
                var cmd = WinCmd.dir(cases);
                run(wf,cmd);
                //run(wf, WinCmd.dir(FS.dir(paths.Test.Root)));

                //run(wf, new CmdLine("llvm-mc --help"));


                // using var dynoshell = new Dynoshell(wf);
                // dynoshell.Run();


                //var shell = WinCmdShell.create(wf);
                // var process = adapt(Process.GetCurrentProcess());
                // var modules = process.Modules.FormatList(Eol);
                // wf.Row(modules);

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