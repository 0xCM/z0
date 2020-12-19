//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Diagnostics;

    using static z;

    class Dynoshell : IDisposable
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly CmdBuilder CmdBuilder;

        public Dynoshell(IWfShell wf)
        {
            Host = WfShell.host(typeof(Dynoshell));
            Wf = wf.WithHost(Host);
            CmdBuilder = wf.CmdBuilder();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        ICmdSpec[] Commands()
        {
            var db = Wf.Db();
            var archive = Wf.RuntimeArchive();
            var buffer = z.list<ICmdSpec>();
            var dst = span<ICmdSpec>(buffer);
            var cmd = default(EmitResourceDataCmd);
            var src = default(Assembly);

            src = archive.Srm;
            cmd = new EmitResourceDataCmd();
            cmd.Source = src;
            cmd.Target = db.Reflected(src);
            cmd.ClearTarget = true;
            buffer.Add(cmd);

            src = archive.CodeAnalysis;
            cmd = new EmitResourceDataCmd();
            cmd.Source = src;
            cmd.Target = db.Reflected(src);
            cmd.ClearTarget = true;
            buffer.Add(cmd);

            buffer.Add(Wf.CmdCatalog.EmitRuntimeIndex());

            buffer.Add(Wf.CmdCatalog.ShowRuntimeArchive());

            return buffer.Array();
        }

        public void DispatchCommands()
        {
            using var flow = Wf.Running();
            using var runner = new ToolRunner(Wf, Host);
            iter(Wf.Router.SupportedCommands.Storage, c => Wf.Status($"{c} enabled"));

            PipeChecks.check(Wf);
        }

        CmdResult EmitAsmMnemonics()
            => Wf.Router.Dispatch(CmdBuilder.EmitAsmMnemonics());

        void EmitPeHeaders()
        {
            var build = BuildArchives.create(Wf);
            var db = Wf.Db();
            var dllTarget = db.Table(ImageSectionHeader.TableId, "z0.dll.headers");
            var exeTarget = db.Table(ImageSectionHeader.TableId, "z0.exe.headers");

            var cmd = CmdBuilder.EmitImageHeaders();
            cmd.Source = build.DllFiles().Array();
            cmd.Target = db.Table(ImageSectionHeader.TableId, "z0.dll.headers");
            EmitImageHeaders.run(Wf, cmd);

            cmd.Source = build.ExeFiles().Array();
            cmd.Target = db.Table(ImageSectionHeader.TableId, "z0.exe.headers");
            EmitImageHeaders.run(Wf, cmd);
        }

        static void PipeImageFiles(IWfShell wf)
        {
            var archive = ImageArchives.csv(wf);
            wf.Status(archive.Root);
            zfunc.iter(archive.Listing().Storage, file => wf.Status(file));
        }

        [Op]
        public void EmitBuildArchiveList(FS.FolderPath src, string label)
        {
            var archive = BuildArchives.create(Wf, src);
            var types = array(archive.Dll, archive.Exe, archive.Pdb, archive.Lib, archive.Xml, archive.Json);
            var cmd = CmdBuilder.ListFiles(label + ".build-artifacts", archive.Root, types);
            Wf.Router.Dispatch(cmd);
        }

        public static void PipeImageData(IWfShell wf, FS.FilePath src)
        {
            using var reader = ImageArchives.reader(wf, src, ImageFormatKind.Csv);
            var record = default(ImageContentRecord);
            var @continue = true;
            while(@continue)
            {
                if(reader.Read(ref record))
                    wf.Row(record.Data);
                else
                    @continue = false;
            }
        }

        public static void PipeImageData(IWfShell wf)
        {
            var root = wf.Db().TableRoot<ImageContentRecord>();
            var archive = ImageArchives.csv(wf);
            var path = archive.Root + FS.file("image.content.advapi32", FileExtensions.Csv);
            PipeImageData(wf, path);

        }
        // CmdResult EmitOpCodes()
        // {
        //     var spec = EmitAsmOpCodes.Spec();
        //     spec.WithTarget(Wf.Db().RefDataPath("asm.opcodes"));
        //     return Wf.Router.Dispatch(spec);
        // }


        public CmdResult EmitAsmOpCodes()
            => Wf.Router.Dispatch(CmdBuilder.EmitAsmOpCodes());


        void WriteJson()
        {
            var db = Wf.Db();
            var commands = Commands();
            foreach(var c in commands)
            {
                var dst = db.TmpFile(FS.file(c.CmdName.Format(), FileExtensions.Json));
                var data = JsonData.serialize(c,dst);
            }
        }


        static void EmitCilTables(IWfShell wf, params string[] components)
        {
            var runtime = wf.RuntimeArchive();
            var srcdir = runtime.Root;
            foreach(var component in components)
            {
                var srcpath = srcdir + FS.file(component);
                if(!srcpath.Exists)
                    wf.Warn($"The {component} component was not found");
                else
                {
                    var cmd = new EmitCliTableDocCmd();
                    var dstfile = FS.file($"{component}.metadata.cli");
                    var dstdir = wf.Db().Output(new ToolId("ztool"), cmd.Id()).Create() + dstfile;
                    cmd.Source = srcpath;
                    cmd.Target = dstdir;
                    (var success, var msg) = MetadataTableEmitter.emit(cmd.Source.Name, cmd.Target.Name);
                    if(success)
                        wf.Status(msg);
                    else
                        wf.Error(msg);
                }
            }
        }

        void EmitReferenceData()
        {
            var xed = XedWf.create(Wf);
            xed.Run();
        }

        void CreateApiIndex()
        {
            var svc = ApiIndex.service(Wf);
            var index = svc.CreateIndex();
        }

        public void Run()
        {
            //EmitProcessImages(Wf);
            //EmitAsmMnemonics();
            //EmitAsmOpCodes();
            //EmitBuildArchiveList(Wf.Db().BuildArchiveRoot(), "zbuild");
            //EmitCilTables(Wf, "z0.bitcore.dll");

            EmitReferenceData();
            // var component = Wf.Api.FindComponent(PartId.BitCore).Require();
            // var result = Cli.EmitCilTableDoc(Wf, component);

            // var cmd = new LocateImagesCmd();
            // cmd.Target = Wf.Db().IndexFile(LocatedImageRow.TableId);
            // Dispatch(cmd);
        }
    }

    readonly struct Msg
    {
        public static RenderPattern<uint,ApiHostUri,uint> IndexedHost => "{2} | {0} | {1} | Api summary accumulation";

        public static RenderPattern<uint,FS.FilePath> EmittedOpIndex => "Emitted operation index for {0} hosts to {1}";

        public static RenderPattern<T> Dispatching<T>()
            where T : struct, ICmdSpec<T> => "Dispatching {0}";

        public static RenderPattern<CmdId> Dispatching() => "Dispatching {0}";
    }
}