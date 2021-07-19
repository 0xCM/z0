//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static IntelSdm;
    using static Root;
    using static core;

    public sealed partial class AsmCmdService : AppCmdService<AsmCmdService>
    {
        const string xed = nameof(xed);

        NativeBuffer CodeBuffer;

        ByteSize CodeSize;

        Identifier RoutineName;

        AsmWorkspace Workspace;

        SymTypes _SymTypes;

        ToolBase _Toolbase;

        ScriptRunner ScriptRunner;

        ToolId _Tool;

        FS.FolderPath _SrcDir;

        FS.FileName _SrcFile;

        FS.FolderPath _DstDir;

        FS.FolderPath WsOutDir;

        FS.Files  _SrcList;

        byte[] _Assembled;

        public AsmCmdService()
        {
            CodeBuffer = Buffers.native(Pow2.T10);
            RoutineName = Identifier.Empty;
            _SymTypes = Z0.SymTypes.Empty;
            _Tool = ToolId.Empty;
            CodeSize = 0;
            _SrcDir = FS.FolderPath.Empty;
            _DstDir = FS.FolderPath.Empty;
            _SrcFile = FS.FileName.Empty;
            _Assembled = array<byte>();
            _SrcList = array<FS.FilePath>();
        }

        protected override void Initialized()
        {
            Workspace = Wf.AsmWorkspace();
            _Toolbase = Wf.ToolBase(Db.ToolWs());
            ScriptRunner = Wf.ScriptRunner();
            WsOutDir = Db.DevWs() + FS.folder(".out");
            _DstDir = WsOutDir;
        }

        protected override void Disposing()
        {
            CodeBuffer.Dispose();
        }


        ToolBase ToolBase()
            => _Toolbase;

        ToolId Tool()
            => _Tool;


        FS.Files SrcList()
            => _SrcList;

        FS.Files SrcList(FS.Files src)
        {
            _SrcList = src;
            iter(src.View, f => Write(f));
            return src;
        }

        FS.FolderPath SrcDir()
            => _SrcDir;

        FS.FileName SrcFile()
            => _SrcFile;

        FS.FolderPath DstDir()
            => _DstDir;

        FS.FolderPath SrcDir(FS.FolderPath value)
        {
            _SrcDir = value;
            return _SrcDir;
        }

        FS.FileName SrcFile(FS.FileName value)
        {
            _SrcFile = value;
            return _SrcFile;
        }

        FS.FolderPath DstDir(FS.FolderPath value)
        {
            _DstDir = value;
            return _DstDir;
        }

        ToolId SelectTool(ToolId id)
        {
            _Tool = id;
            return _Tool;
        }

        ToolId SelectedTool()
            => _Tool;


        SymTypes SymTypes
        {
            get
            {
                if(_SymTypes.IsEmpty)
                    _SymTypes = Clr.symtypes(ApiRuntimeLoader.assemblies());
                return _SymTypes;
            }
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

            var dst = WsOutDir + FS.file(string.Format("{0}.list", src.FolderName), FS.Csv);
            Tables.emit(files.View, dst);
        }

        Outcome DumpModule(FileModuleKind kind)
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
                ("DstDir", DstDir().Format(PathSeparator.BS))
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

        static MsgPattern<Count,TableKind> DispatchingRows => "Dispatching {0} {1} rows";
    }
}