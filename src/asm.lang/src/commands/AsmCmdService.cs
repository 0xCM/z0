//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    public sealed partial class AsmCmdService : AppCmdService<AsmCmdService>
    {
        NativeBuffer CodeBuffer;

        ByteSize CodeSize;

        Identifier RoutineName;

        AsmWorkspace Workspace;

        ScriptRunner ScriptRunner;

        byte[] _Assembled;

        ShellState State;

        public AsmCmdService()
        {
            State = new ShellState();
            CodeBuffer = Buffers.native(Pow2.T14);
            RoutineName = Identifier.Empty;
            CodeSize = 0;
            _Assembled = array<byte>();
        }

        protected override void Initialized()
        {
            Workspace = Wf.AsmWorkspace();
            ScriptRunner = Wf.ScriptRunner();
            State.ToolBase(Wf.ToolBase(Db.ToolWs()));
            State.OutDir(OutRoot());
            State.ProjectBase(Wf.ProjectBase(FS.dir("j:/projects")));
            State.Project("default");
            State.Tables(Db.DevWs() + FS.folder("tables"));
        }

        protected override void Disposing()
        {
            CodeBuffer.Dispose();
        }

        ToolBase ToolBase()
            => State.ToolBase();

        ProjectBase Projects()
            => State.Projects();

        ProjectId Project(ProjectId id)
            => State.Project(id);

        ProjectId Project()
            => State.Project();

        ToolId Tool()
            => State.Tool();

        ToolId Tool(ToolId id)
            => State.Tool(id);

        FS.Files Files()
            => State.Files();

        FS.Files Files(FS.FileExt ext)
            => State.Files().Where(f => f.Is(ext));

        FS.Files Files(FS.Files src, bool write = true)
        {
            State.Files(src);
            if(write)
                iter(src.View, f => Write(f));
            return src;
        }

        FS.FolderPath OutRoot()
            => FS.dir("j:/ws/.out");

        FS.FolderPath SrcDir()
            => State.SrcDir();

        FS.FolderPath OutDir()
            => State.OutDir();

        FS.FolderPath OutDir(FS.FolderName value)
            => State.OutDir(OutRoot() + value);

        FS.FolderPath SrcDir(FS.FolderPath value)
            => State.SrcDir(value);

        TableArchive TA()
            => State.Tables();

        TableArchive TA(FS.FolderPath root)
            => State.Tables(root);

        FS.FilePath TAPath<T>()
            where T : struct
                => TA().Path<T>();

        FS.FilePath DataSource()
            => State.DataSource();

        FS.FilePath DataSource(FS.FilePath src)
            => State.DataSource(src);

        Outcome ToolOutDir(CmdArgs args, out FS.FolderPath dir)
        {
            dir = FS.FolderPath.Empty;
            if(args.Length == 0)
                return (false, ToolUnspecified.Format());

            var id = arg(args,0).Value;
            dir = OutDir() + FS.folder(id);
            return true;
        }

        FS.FolderPath ToolOutDir(ToolId tool)
            => OutDir() + FS.folder(tool.Format());

        Outcome LoadCodeBuffer(string name, ReadOnlySpan<byte> src)
        {
            RoutineName = name;
            CodeBuffer.Clear();
            var size = src.Length;
            if(size > CodeBuffer.Size)
                return (false,CapacityExceeded.Format());

            var buffer = CodeBuffer.Edit;
            for(var i=0; i<size; i++)
                seek(buffer,i) = skip(src,i);
            CodeSize = size;
            return true;
        }

        Outcome RunScript(FS.FilePath src, out ReadOnlySpan<TextLine> response)
        {
            var result = Outcome.Success;

            void OnError(Exception e)
            {
                result = e;
            }

            var cmd = Cmd.cmdline(src.Format(PathSeparator.BS));
            response = ScriptRunner.RunCmd(cmd, OnError);
            return result;
        }

        Outcome RunTool(CmdArgs args, Func<ToolId,CmdArgs,Outcome> f)
        {
            var tool = args.IsNonEmpty ? (ToolId)arg(args,0).Value : Tool();
            if(tool.IsEmpty)
                return (false, NoToolSelected.Format());
            else
                return f(tool, args);
        }

        ref readonly Table Pipe(in Table src)
        {

            return ref src;
        }

        ref readonly FS.FilePath Pipe(in FS.FilePath src)
        {
            Write(string.Format("Path:{0}",src));
            return ref src;
        }

        ref readonly ReadOnlySpan<T> Pipe<T>(in ReadOnlySpan<T> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(src,i);
                Write(input.ToString());
            }
            return ref src;
        }

        void List(FS.FolderPath src)
        {
            var files = FileArchives.list(src);
            iter(files.View, file => Write(file.Path));

            var dst = State.OutDir() + FS.file(string.Format("{0}.list", src.FolderName), FS.Csv);
            Z0.Tables.emit(files.View, dst);
        }

        FS.FolderPath ToolOutDir(CmdArgs args, ToolId tool)
            => args.Length > 0 ? OutDir() + FS.folder(arg(args,0).Value) : ToolOutDir(tool);

        Outcome DumpModules(CmdArgs args, FileModuleKind kind)
        {
            var script = kind switch{
                FileModuleKind.Obj => "dump-obj",
                FileModuleKind.Exe => "dump-exe",
                FileModuleKind.Lib => "dump-lib",
                FileModuleKind.Dll => "dump-dll",
                _ => EmptyString
            };

            if(empty(script))
                return (false, string.Format("{0} not supported", kind));

            var tool = Toolspace.dumpbin;
            var outdir = ToolOutDir(args, tool);
            var cmd = Cmd.cmdline(ToolBase().Script(tool, script).Format(PathSeparator.BS));
            var input = Files().View;
            var count = input.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(input,i);
                var vars = Cmd.vars(
                    ("SrcDir", path.FolderPath.Format(PathSeparator.BS)),
                    ("SrcFile", path.FileName.Format()),
                    ("DstDir", outdir.Format(PathSeparator.BS))
                    );

                var response = ScriptRunner.RunCmd(cmd, vars);
            }
            return true;
        }

        static MsgPattern NoToolSelected => "No tool selected";

        static MsgPattern CapacityExceeded => "Capacity exceeded";

        static MsgPattern ToolUnspecified => "Tool unspecified";

        static MsgPattern<ToolId> UndefinedTool => "Undefined tool:{0}";

        static MsgPattern<ProjectId> UndefinedProject => "Undefined project:{0}";
    }
}