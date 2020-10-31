//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.IO;
    using System.Text;

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

        readonly ReadOnlySpan<string> AppArgs;

        readonly CmdBuilder CmdBuilder;

        readonly IFileDb Db;

        public AppRunner(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Mpx = Multiplex.create(wf, Multiplex.configure(wf.Db().Root));
            AppArgs = wf.Args;
            CmdBuilder = wf.CmdBuilder();
            Db = Wf.Db();
        }

        CmdResult EmitOpCodes()
            => EmitAsmOpCodes.run(Wf);

        CmdResult EmitPatterns()
            => EmitRenderPatterns.run(Wf, CmdBuilder.EmitRenderPatterns(typeof(RP)));

        CmdResult EmitSymbols()
            => EmitAsmSymbols.run(Wf, CmdBuilder.EmitAsmSymbols());

        void EmitScripts()
            => EmitToolScripts.run(Wf, EmitToolScripts.specify(Wf));

        CmdResult EmitToolHelp()
            => EmitResData.run(Wf, CmdBuilder.EmitResData(Parts.Tools.Assembly, "res/tools/help", ".help"));

        CmdResult EmitCaseLogs()
            => EmitResData.run(Wf, CmdBuilder.EmitResData(Parts.Tools.Assembly, "res/tools/caselogs", ".log"));

        CmdResult EmitAsmRefs()
        {
            var srcDir = FS.dir("k:/z0/builds/nca.3.1.win-x64");
            var sources = array(srcDir + FS.file("z0.konst.dll"), srcDir + FS.file("z0.asm.dll"));
            var dst = Db.Doc("AssemblyReferences", ArchiveFileKinds.Csv);
            var cmd = EmitAssemblyRefs.specify(Wf, sources, dst);
            return EmitAssemblyRefs.run(Wf,cmd);
        }

        void EmitPeHeaders()
        {
            var build = BuildArchiveFactory.Z(Wf);
            var dllTarget = Wf.Db().Table(ImageSectionHeader.TableId, "z0.dll.headers");
            var exeTarget = Wf.Db().Table(ImageSectionHeader.TableId, "z0.exe.headers");
            EmitImageHeaders.run(Wf, EmitImageHeadersCmd.specify(Wf, build.DllFiles().Array(), dllTarget));
            EmitImageHeaders.run(Wf, EmitImageHeadersCmd.specify(Wf, build.ExeFiles().Array(), exeTarget));
        }

        static CmdResult ListBuildFiles(IWfShell wf, BuildArchiveSettings spec)
        {
            var archive = BuildArchive.create(wf, spec);
            return  EmitFileListing.run(wf, EmitFileListing.specify(wf, spec.Label + ".artifacts", archive.Root, array(archive.Dll, archive.Exe, archive.Pdb, archive.Lib)));
        }

        void PrintArgs()
        {
            var count = AppArgs.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var arg = ref skip(AppArgs,i);
                Wf.Status(arg);
            }

        }

        void EmitApiSummaries()
        {
            var api = Wf.Api;
            var parts = api.PartIdentities;
            var data = ApiSummaries.parts(Wf, parts);
            var dst = ApiSummaries.target(Db);
            Wf.EmittingTable(typeof(ApiSummaryInfo), dst);
            ApiSummaries.emit(data,dst);
            Wf.EmittedTable(typeof(ApiSummaryInfo), data.Length, dst);

        }

        void RunAll()
        {
            EmitOpCodes();
            EmitPatterns();
            EmitToolHelp();
            EmitCaseLogs();
            EmitSymbols();
            EmitScripts();
            EmitAsmRefs();
            EmitPeHeaders();
            EmitApiSummaries();
        }

        void ShowCases()
        {
            var query = Resources.query(Wf.Controller, CaseNames.CoreClrBuildLog);
            if(query.ResourceCount == 1)
            {
                var data = query.Descriptor(0).Utf8();
                using var reader = new StringReader(data.ToString());
                var line = reader.ReadLine();
                while(line != null)
                {
                    term.print(line);
                    line = reader.ReadLine();
                }
            }

        }

        public unsafe void Run()
        {
            var hosts = @readonly(Wf.Api.ApiHosts);
            var kHost = hosts.Length;
            for(var i=0; i<kHost; i++)
            {
                var catalog = ApiCatalogs.members(skip(hosts,i));
                var members = catalog.Members;
                var kMember = members.Length;
                for(var j=0; j<kMember; j++)
                {
                    ref readonly var member = ref skip(members,i);
                    var method = member.Method;
                    if(method.IsNonGeneric())
                    {
                        try
                        {
                            var metdata = method.Metadata();
                            // var sig = ClrSigs.resolve(member.Method);
                            // var row = delimit(method.Signature(), sig);
                            // Wf.Row(row);
                        }
                        catch(Exception e)
                        {
                            Wf.Error($"{method.Name}:{e.Message}");
                        }
                    }
                }
            }
        }


        public void Dispose()
        {

        }
    }

    public static partial class XTend { }
}