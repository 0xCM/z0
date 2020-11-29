//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.IO;
    using System.Linq;
    using System.Diagnostics;

    using static z;

    public struct ToolRunner : IDisposable
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly Multiplex Mpx;

        readonly string[] Args;

        readonly CmdBuilder CmdBuilder;

        readonly IFileDb Db;

        public ToolRunner(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Mpx = Multiplex.create(wf, Multiplex.configure(wf.Db().Root));
            Args = wf.Args;
            CmdBuilder = wf.CmdBuilder();
            Db = Wf.Db();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        CmdResult EmitOpCodes()
        {
            var spec = EmitAsmOpCodes.Spec();
            spec.WithTarget(Wf.Db().RefDataPath("asm.opcodes"));
            return Wf.Router.Dispatch(spec);
        }

        CmdResult EmitPatterns()
            => EmitRenderPatterns.run(Wf, Wf.CmdCatalog.EmitRenderPatterns(typeof(RP)));

        CmdResult EmitSymbols()
            => EmitAsmSymbols.run(Wf, CmdBuilder.EmitAsmSymbols());

        [Op]
        public static FS.FilePath[] match(FS.FolderPath root, params FS.FileExt[] ext)
        {
            var files = FileArchives.create(root, ext).Files().Array();
            Array.Sort(files);
            return files;
        }

        [Op]
        public static FS.FilePath[] match(FS.FolderPath root, uint max, params FS.FileExt[] ext)
        {
            var files = FileArchives.create(root, ext).Files().Take(max).Array();
            Array.Sort(files);
            return files;
        }

        [Op]
        public static CmdResult exec(EmitFileListCmd cmd)
        {
            var archive = FileArchives.create(cmd.SourceDir, cmd.FileKinds);
            var id = Cmd.id(cmd);
            var list = cmd.EmissionLimit != 0 ? match(cmd.SourceDir, cmd.EmissionLimit, cmd.FileKinds) : match(cmd.SourceDir, cmd.FileKinds);
            var outcome = FileArchives.emit(list, cmd.FileUriMode, cmd.TargetPath);
            return outcome ? Cmd.ok(cmd) : Cmd.fail(cmd,outcome.Format());
        }

        // CmdResult EmitToolHelp()
        //     => EmitResourceData.run(Wf, CmdBuilder.EmitResourceData(Parts.Refs.Assembly, "tools/help", ".help"));

        CmdResult EmitFileList()
            => exec(Wf.EmitFileListCmdSample());

        CmdResult EmitAsmRefs()
        {
            var srcDir = FS.dir("k:/z0/builds/nca.3.1.win-x64");
            var sources = array(srcDir + FS.file("z0.konst.dll"), srcDir + FS.file("z0.asm.dll"));
            var dst = Db.Doc("AssemblyReferences", ArchiveFileKinds.Csv);
            var cmd = EmitAssemblyRefs.specify(Wf, sources, dst);
            return EmitAssemblyRefs.run(Wf,cmd);
        }

        void Summarize(ApiCodeBlock src)
        {
            Wf.Status(Host, src.OpUri);
        }

        void Emit(ReadOnlySpan<ApiCodeDescriptor> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                writer.WriteLine(string.Format(ApiCodeDescriptor.FormatPattern, block.Part, block.Host, block.Base, block.Size, block.Uri));
            }
        }

        void EmitPeHeaders()
        {
            var build = BuildArchives.create(Wf);
            var dllTarget = Wf.Db().Table(ImageSectionHeader.TableId, "z0.dll.headers");
            var exeTarget = Wf.Db().Table(ImageSectionHeader.TableId, "z0.exe.headers");

            var cmd = Wf.CmdCatalog.EmitImageHeaders();
            cmd.Sources = build.DllFiles().Array();
            cmd.Target = Wf.Db().Table(ImageSectionHeader.TableId, "z0.dll.headers");
            EmitImageHeaders.run(Wf, cmd);

            cmd.Sources = build.ExeFiles().Array();
            cmd.Target = Wf.Db().Table(ImageSectionHeader.TableId, "z0.exe.headers");
            EmitImageHeaders.run(Wf, cmd);
        }

        void RunFxWorkflows()
        {
            FxWf.run(Wf);
        }

        void ShowLetters()
        {
            using var flow = Wf.Running();
            var data = Resources.strings(typeof(AsciLetterLoText));
            var resources = @readonly(data);
            var rows = Resources.rows(data).View;
            var count = resources.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var res = ref skip(resources,i);
                ref readonly var row = ref skip(rows,i);
                Wf.Row(row);
            }
        }

        void Show(ListedFiles src)
        {
            for(var i=0; i<src.Count; i++)
                Wf.Row(src[i]);
        }

        FS.FilePath AppDataPath(FS.FileName file)
            => Wf.AppData + file;

        static string[] DebugFlags(Assembly src)
            => src.GetCustomAttributes<DebuggableAttribute>().Select(a => a.DebuggingFlags.ToString()).Array();

        void ShowDebugFlags()
        {
            var archive = RuntimeArchive.create();
            var src = archive.ManagedLibraries.Select(x => Assembly.LoadFrom(x.Name));
            var rows = map(src, f => delimit(f.GetSimpleName(), delimit(DebugFlags(f))));
            Wf.Rows(rows);
        }

        void ShowArgs()
        {
            for(var i=0; i<Args.Length; i++)
                Wf.Row(Args[i]);
        }

        void ShowTokens()
        {
            var tokens = array<int>(typeof(byte).MetadataToken, typeof(sbyte).MetadataToken, typeof(char).MetadataToken);
            Wf.Status(delimit(tokens.Map(t => t.FormatHex())));
        }

        void ShowApiHex()
        {
            var archive = ApiArchives.hex(Wf);
            var listing = archive.List();
            if(listing.Count == 0)
                Wf.Warn(Host, $"No files found in archive with root {archive.Root}");
            Show(listing);
        }

        public void Run(ICmdSpec spec)
        {
            Wf.Status(Msg.Dispatching().Apply(spec.CmdId));
            Wf.Router.Dispatch(spec);
        }

        public void Run<T>(T spec)
            where T : struct, ICmdSpec<T>
        {
            Wf.Status(Msg.Dispatching<T>().Apply(spec));
            Wf.Router.Dispatch(spec);
        }

        void ShowDependencies()
        {
            ShowDependencies(Wf.Controller);
        }

        void ShowDependencies(Assembly src)
        {
            var deps = JsonDeps.dependencies(src);
            var libs = deps.Libraries();


            //Wf.Row(JsonDeps.json(src));
        }

        void ShowCmdModels()
        {
            var models = @readonly(Cmd.cmdtypes(Wf));
            var buffer = Buffers.text();
            for(var i=0; i<models.Length; i++)
            {
                Cmd.render(skip(models,i), buffer);
                Wf.Row(buffer.Emit());
            }
        }

        void RunAll()
        {
            EmitOpCodes();
            EmitPatterns();
            //EmitToolHelp();
            EmitSymbols();
            EmitAsmRefs();
            EmitPeHeaders();
        }

        void ShowOptions()
        {
            var result = CmdSpecs.parse(CmdCases.Case0);
            if(result.Succeeded)
            {
                var value = result.Value;
                var msg = string.Format("cmd:{0} | options:{1}", value.CmdId, CmdArgs.format(value.Args));
                Wf.Status(msg);

            }
            else
                Wf.Error(result.Reason);
        }

        void ShowCases()
        {
            var query = Resources.query(Wf.Controller, CmdCases.CoreClrBuildLog);
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

        public void Run()
        {
            var models = @readonly(Cmd.cmdtypes(Wf));
            var count = models.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var model = ref skip(models,i);
                Wf.Row(string.Format("{0,-3} {1}", i, model.DataType.Name));
            }
        }

        public readonly struct CmdCases
        {
            public const string CoreClrBuildLog = "CoreCLR_Windows_NT__x64__Debug.log";

            public const string Case0 = @"llvm-pdbutil dump --streams J:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64\z0.math.pdb > z0.math.pdb.streams.log";
        }
    }
}