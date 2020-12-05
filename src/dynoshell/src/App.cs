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
            wf.Status(wf.Db().DbRoot);
        }

        static void react(IWfShell wf, in EmitCliTablesCmd cmd)
        {
            (var success, var msg) = SRM.MetadataTableEmitter.emit(cmd.Source.Name, cmd.Target.Name);
            if(success)
                wf.Status(msg);
            else
                wf.Error(msg);
        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfShell.create(args).WithRandom(Rng.@default());

                var cmd = new EmitCliTablesCmd();
                cmd.Source = FS.path(wf.Component(PartId.Konst).Require().Location);
                cmd.Target = wf.Db().Output(new ToolId("ztool"), cmd.Id()).Create() + FS.file("z0.konst.metadata.cli");
                react(wf,cmd);

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