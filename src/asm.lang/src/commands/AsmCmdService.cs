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
            State.OutDir(FS.dir("j:/ws/.out"));
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

        FS.Files Files(FS.Files src)
        {
            State.Files(src);
            iter(src.View, f => Write(f));
            return src;
        }

        FS.FolderPath SrcDir()
            => State.SrcDir();

        FS.FolderPath OutDir()
            => State.OutDir();

        FS.FolderPath SrcDir(FS.FolderPath value)
            => State.SrcDir(value);

        FS.FolderPath OutDir(FS.FolderPath value)
            => State.OutDir(value);

        TableArchive Tables()
            => State.Tables();

        TableArchive Tables(FS.FolderPath root)
            => State.Tables(root);

        FS.FilePath TablePath<T>()
            where T : struct
                => Tables().Path<T>();

        Outcome ToolOutDir(CmdArgs args, out FS.FolderPath dir)
        {
            dir = FS.FolderPath.Empty;
            if(args.Length == 0)
                return (false, ToolUnspecified.Format());

            if(Arg(args,0, out var id))
            {
                dir = OutDir() + FS.folder(id.Value);
                return true;
            }
            return false;
        }

        Outcome LoadRoutine(string name, ReadOnlySpan<byte> src)
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
            //Status(DispatchingRows.Format(src.RowCount, src.Kind));
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

        ReadOnlySpan<TextLine> DumpObj(FS.FilePath src, FS.FolderPath dst)
        {
            var cmd = Cmd.cmdline(ToolBase().Script(Toolspace.dumpbin, "dump-obj").Format(PathSeparator.BS));
            var vars = Cmd.vars(
                ("SrcDir", src.FolderPath.Format(PathSeparator.BS)),
                ("DstDir", dst.Format(PathSeparator.BS)),
                ("SrcFile", src.FileName.Format())
                );
            return ScriptRunner.RunCmd(cmd, vars);
        }

        Outcome DumpModules(FileModuleKind kind)
        {
            var script = kind switch{
                FileModuleKind.Obj => "dump-obj",
                FileModuleKind.Exe => "dump-exe",
                FileModuleKind.Lib => "dump-lib",
                FileModuleKind.Dll => "dump-dll",
                _ => EmptyString
            };


            var ext = kind switch{
                FileModuleKind.Dll => FS.Dll,
                FileModuleKind.Obj => FS.Obj,
                FileModuleKind.Exe => FS.Exe,
                FileModuleKind.Lib => FS.Lib,
                _ => FS.FileExt.Empty
            };


            if(empty(script))
                return (false, string.Format("{0} not supported", kind));

            var cmd = Cmd.cmdline(ToolBase().Script(Toolspace.dumpbin, script).Format(PathSeparator.BS));
            var input = SrcDir().Files(ext).ToReadOnlySpan();
            var count = input.Length;
            var vars = Cmd.vars(
                ("SrcDir", SrcDir().Format(PathSeparator.BS)),
                ("DstDir", OutDir().Format(PathSeparator.BS))
                );
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(input,i);
                vars[2] = ("SrcFile", path.FileName.Format());
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