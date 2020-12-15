//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

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

        static void PipeRuntimeFiles(IWfShell wf)
        {
            var archive = wf.RuntimeArchive();
            PipeFiles(wf, archive.DllFiles);
            PipeFiles(wf, archive.ExeFiles);
            PipeFiles(wf, archive.PdbFiles);
            PipeFiles(wf, archive.JsonFiles);
            PipeFiles(wf, archive.XmlFiles);
        }

        static void PipeFiles(IWfShell wf, FS.Files src)
        {
            foreach(var file in src)
                wf.Status(file.ToUri().Format());
        }

        static void RunInterpreter(IWfShell wf)
        {
            var cmd = WinCmdShell.create(wf);
            cmd.Submit("dir J:\\");
            cmd.Run();
            cmd.WaitForExit();
        }


        static void Run32(IWfShell wf)
        {
            var llvm = Llvm.service(wf);
            var paths = llvm.Paths();
            var cases = paths.Test.ModuleDir(ModuleNames.Analysis, TestSubjects.AliasSet);
            var cmd = WinCmd.dir(cases);
            //run(wf, WinCmd.dir(FS.dir(paths.Test.Root)));
            //run(wf, new CmdLine("llvm-mc --help"));

            run(wf,cmd);
        }

        static void ShowConfig(IWfShell wf)
        {
            wf.Status(wf.Settings.FormatList());
            wf.Status(wf.Db().Root);
        }

        public static void Main(params string[] args)
        {
            try
            {

                using var wf = WfShell.create(args).WithRandom(Rng.@default());
                var host = new App();
                host.Execute(wf);

                //PipeRuntimeFiles(wf);
                //EmitCilTables(wf, "z0.gmath.dll");
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