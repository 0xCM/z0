//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static z;

    sealed class App : WfHost<App>
    {

        public App()
        {

        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfShell.create(args);
                using var runner = new AppRunner(wf, App.create());
                runner.Run();
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
    }

    ref struct AppRunner
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly Multiplex Mpx;

        public AppRunner(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Mpx = Multiplex.create(wf, Multiplex.configure(wf.Db().Root));
        }

        CmdResult EmitOpCodes()
            => EmitAsmOpCodes.run(Wf);

        CmdResult EmitPatterns()
            => EmitRenderPatterns.run(Wf, Wf.CmdBuilder().EmitRenderPatterns(typeof(RP)));

        CmdResult EmitSymbols()
            => EmitAsmSymbols.run(Wf, Wf.CmdBuilder().EmitAsmSymbols());

        void EmitScripts()
            => EmitToolScripts.run(Wf, EmitToolScripts.specify(Wf));

        CmdResult EmitRes()
            => EmitResourceContent.run(Wf, EmitResourceContent.specify(Wf, Wf.Controller));

        CmdResult EmitAsmRefs()
        {
            var srcDir = FS.dir("k:/z0/builds/nca.3.1.win-x64");
            var sources = array(srcDir + FS.file("z0.konst.dll"), srcDir + FS.file("z0.asm.dll"));
            var dst = Wf.Db().Doc("AssemblyReferences", ArchiveFileKinds.Csv);
            var cmd = EmitAssemblyRefs.specify(Wf, sources, dst);
            return EmitAssemblyRefs.run(Wf,cmd);
        }

        static CmdResult ListBuildFiles(IWfShell wf)
        {
            var a = BuildArchives.Roslyn(wf);
            return  EmitFileListing.run(wf, EmitFileListing.specify(wf, "roslyn.artifacts", a.Root, array(a.Dll)));
        }

        public unsafe void Run()
        {
            // EmitOpCodes();
            // EmitPatterns();
            // EmitRes();
            // EmitSymbols();
            // EmitScripts();
            // EmitAsmRefs();
            ListBuildFiles(Wf);
        }


        public void Dispose()
        {

        }
    }

    public static partial class XTend { }
}