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
    using System.Linq;
    using System.Diagnostics;

    using D = ApiDataModel;

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

        protected override void Execute(IWfShell shell)
        {
            throw new NotImplementedException();
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
            => EmitRenderPatterns.run(Wf, Wf.CmdCatalog.EmitRenderPatterns(typeof(RP)));

        CmdResult EmitSymbols()
            => EmitAsmSymbols.run(Wf, CmdBuilder.EmitAsmSymbols());

        void EmitScripts()
            => EmitToolScripts.run(Wf, EmitToolScripts.specify(Wf));

        CmdResult EmitToolHelp()
            => EmitResData.run(Wf, CmdBuilder.EmitResData(Parts.Tools.Assembly, "res/tools/help", ".help"));

        CmdResult EmitCaseLogs()
            => EmitResData.run(Wf, CmdBuilder.EmitResData(Parts.Tools.Assembly, "res/tools/caselogs", ".log"));

        CmdResult EmitFileList()
            => FileEmissions.exec(Wf.EmitFileListCmdSample());

        CmdResult EmitRuntimeIndex()
        {
            using var flow = Wf.Running();
            var cmd = Wf.CmdCatalog.EmitRuntimeIndex();
            var worker = cmd.Worker();
            var result  = worker.Invoke(Wf, cmd);
            Wf.Status(result);
            return result;

        }
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

        void Emit(ReadOnlySpan<D.CodeBlockDescriptor> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                writer.WriteLine(string.Format(D.CodeBlockDescriptor.FormatPattern, block.Part, block.Host, block.Base, block.Size, block.Uri));
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

        void PrintArgs()
        {
            var count = AppArgs.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var arg = ref skip(AppArgs,i);
                Wf.Status(arg);
            }
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
                Wf.RowData(row);
            }
        }

        void Show(in ListedFiles src)
        {
            for(var i=0; i<src.Count; i++)
                Wf.RowData(src[i]);
        }

        FS.FilePath AppDataPath(FS.FileName file)
            => Wf.AppData + file;

        void ShowRuntimeArchive()
        {
            var archive = RuntimeArchive.create();
            var resolver = new PathAssemblyResolver(archive.Files.Select(x => x.Name.Text));
            using var context = new MetadataLoadContext(resolver);
            iter(archive.ManagedLibraries, path => context.LoadFromAssemblyPath(path.Name));
            var assemblies = context.GetAssemblies();
            foreach(var a in assemblies)
                Wf.Status(a.GetSimpleName());
        }

        void ShowDebugFlags()
        {
            var archive = RuntimeArchive.create();
            var src = archive.ManagedLibraries.Select(x => Assembly.LoadFrom(x.Name));
            var rows = map(src, f => delimit(f.GetSimpleName(), delimit(f.DebugFlags())));
            Wf.Rows(rows);
        }

        void ShowTokens()
        {
            var tokens = array<int>(typeof(byte).MetadataToken, typeof(sbyte).MetadataToken, typeof(char).MetadataToken);
            Wf.Status(delimit(tokens.Map(t => t.FormatHex())));
        }

        void ShowApiHex()
        {
            var archive = ApiFiles.hex(Wf);
            var listing = archive.List();
            if(listing.Count == 0)
                Wf.Warn(Host, $"No files found in archive with root {archive.Root}");
            Show(listing);
        }

        public void Run(CmdSpec spec)
        {

        }

        void ShowDependencies(Assembly src)
        {
            var deps = JsonDeps.dependencies(src);
            var options = deps.OptionData();
            var json = JsonData.serialize(options);
            Wf.Row(json);

        }

        void ShowCmdModels()
        {
            var models = @readonly(Cmd.models(Wf));
            var buffer = Buffers.text();
            for(var i=0; i<models.Length; i++)
            {
                Cmd.render(skip(models,i), buffer);
                Wf.RowData(buffer.Emit());
            }
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
            var result = Cmd.parse(CmdCases.Case0);
            if(result.Succeeded)
            {
                var value = result.Value;
                var msg = string.Format("cmd:{0} | options:{1}", value.Id, Cmd.format(value.Options));
                Wf.Status(msg);

            }
            else
                Wf.Error(result.Reason);
        }


        public void Dispose()
        {

        }
    }

    public static partial class XTend
    {
        public static string[] DebugFlags(this Assembly src)
            => src.GetCustomAttributes<DebuggableAttribute>().Select(a => a.DebuggingFlags.ToString()).Array();
    }

}