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

        void EmitPeHeaders()
        {
            var build = BuildArchives.Z(Wf);
            var dllTarget = Wf.Db().Table(ImageSectionHeader.TableId, "z0.dll.headers");
            var exeTarget = Wf.Db().Table(ImageSectionHeader.TableId, "z0.exe.headers");
            EmitImageHeaders.run(Wf, EmitImageHeaders.specify(Wf, build.DllFiles().Array(), dllTarget));
            EmitImageHeaders.run(Wf, EmitImageHeaders.specify(Wf, build.ExeFiles().Array(), exeTarget));
        }

        static CmdResult ListBuildFiles(IWfShell wf, BuildArchiveSpec spec)
        {
            var archive = BuildArchive.create(wf, spec);
            return  EmitFileListing.run(wf, EmitFileListing.specify(wf, spec.Label + ".artifacts", archive.Root, array(archive.Dll, archive.Exe, archive.Pdb, archive.Lib)));
        }

        public unsafe void Run()
        {
            // EmitOpCodes();
            // EmitPatterns();
            // EmitRes();
            // EmitSymbols();
            // EmitScripts();
            // EmitAsmRefs();
            ListBuildFiles(Wf, BuildArchiveSpecs.Runtime);
            //EmitPeHeaders();
        }


        public void Dispose()
        {

        }
    }

    public static partial class XTend { }
}