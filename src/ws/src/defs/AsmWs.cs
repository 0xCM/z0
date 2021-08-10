//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static EnvFolders;

    public sealed class AsmWsScripts : WsScripts<AsmWsScripts>
    {
        public ScriptId llc_builds => "llc-builds";
    }

    public sealed class AsmWs : IWorkspace<AsmWs>
    {
        const string analysis = nameof(analysis);

        const string images = nameof(images);

        [MethodImpl(Inline)]
        public static AsmWs create(FS.FolderPath root)
            => new AsmWs(root);

        FS.FolderPath _WsRoot;

        EnvData _Env;

        [MethodImpl(Inline)]
        AsmWs(FS.FolderPath root)
        {
            _WsRoot = root;
            _Env = Env.load().Data;
        }

        public FS.FolderPath Root
        {
            [MethodImpl(Inline)]
            get => _WsRoot;
        }

        public FS.FolderPath WsRoot()
            => _WsRoot;

        FS.FolderPath DevWs
            => _Env.DevWs;

        public FS.FolderPath WsRoot(FS.FolderPath src)
        {
            _WsRoot = src;
            return WsRoot();
        }

        public FS.FolderPath Control()
            => Root + FS.folder(dotcmd);

        public FS.FolderPath DumpArchive()
            => FS.dir("j:/dumps");

        public FS.FilePath ArchiveDump(string id, FS.FileExt ext)
            => DumpArchive() + FS.file(id, ext);

        public FS.FolderPath ArchiveImageDumps()
            => DumpArchive() + FS.folder(images);

        public FS.FolderPath ArchiveImageDumps(string id)
            => ArchiveImageDumps() + FS.folder(id);

        public FS.FilePath ToolPath(ToolId id)
        {
            if(id == Toolspace.bddiasm)
                return FS.path(@"j:\source\bddisasm\build\bddisasm.exe");
            else if(id == Toolspace.nasm)
                return FS.path(@"c:\tools\nasm\nasm.exe");
            else
                throw no(id);
        }

        public FS.FolderPath DataSources()
            => DevWs + FS.folder(WsNames.sources);

        /// <summary>
        /// Defines a path of the form {Root}/.out
        /// </summary>
        public FS.FolderPath OutDir()
            => Root + FS.folder(dotout);

        public FS.FolderPath OutDir(string id)
            => OutDir() + FS.folder(id);

        /// <summary>
        /// Defines a path of the form {Root}/src
        /// </summary>
        public FS.FolderPath Src()
            => Root + FS.folder(src);

        /// <summary>
        /// Defines a path of the form {Src}/asm
        /// </summary>
        public FS.FolderPath AsmLibSrc()
            => Src() + FS.folder("asm");

        public FS.FolderPath AsmAppSrc()
            => Src() + FS.folder("apps");

        public FS.FilePath AsmPath(string id)
            => AsmLibSrc() + FS.file(id, FS.Asm);

        public FS.FolderPath HexDir()
            => OutDir() + FS.folder(hex);

        public FS.FilePath AsmHexPath(string id)
            => HexDir() + FS.file(id, FS.Hex);

        public FS.FilePath HexArrayPath(string id)
            => HexDir() + FS.file(string.Format("{0}.array",id), FS.Hex);

        public FS.FolderPath DataRoot()
            => Root + FS.folder(data);

        /// <summary>
        /// Defines a path of the form {ImportRoot} := {DataRoot}/imported
        /// </summary>
        public FS.FolderPath ImportRoot()
            => DataRoot() + FS.folder(EnvFolders.imported);

        /// <summary>
        /// Defines a path of the form {DataRoot}/datasets
        /// </summary>
        public FS.FolderPath Datasets()
            => DataRoot() + FS.folder(datasets);

        /// <summary>
        /// Defines a path of the form {Output}/bin
        /// </summary>
        public FS.FolderPath Bin()
            => OutDir() + FS.folder(bin);

        public FS.FolderPath Tables()
            => DataRoot() + FS.folder(tables);

        public FS.FilePath Table(string id, FS.FileExt ext)
            => Tables() + FS.file(id,ext);

        public FS.FilePath Table<T>()
            where T : struct
                => Table(TableId<T>(), FS.Csv);

        public FS.FilePath Table<T>(FS.FileExt ext)
            where T : struct
                => Table(TableId<T>(), ext);

        public FS.FolderPath DisasmOut()
            => OutDir() + FS.folder("dis");

        public FS.FolderPath Analysis()
            => OutDir() + FS.folder(analysis);

        public FS.FolderPath ObjOut()
            => OutDir() + FS.folder(obj);

        public FS.FolderPath DumpOut()
            => OutDir() + FS.folder(dumps);

        public FS.FolderPath ExeOut()
            => OutDir() + FS.folder(exe);

        public FS.FilePath BinPath(string id)
            =>  Bin() + FS.file(id, FS.Bin);

        public FS.FolderPath Lists()
            => OutDir() + FS.folder("list");

        public FS.FilePath ObjPath(string id)
            => ObjOut() + FS.file(id,FS.Obj);

        public FS.FilePath ExePath(string id)
            => ExeOut() + FS.file(id,FS.Exe);

        public FS.FilePath ListPath(string id)
            => Lists() + FS.file(id, FS.AsmList);

        public FS.FilePath DisasmPath(string id, ToolId tool, FS.FileExt? ext = null)
            => DisasmOut() + FS.file(string.Format("{0}.{1}", id, tool), ext ?? FS.Asm);

        public AsmToolchainSpec ToolchainSpec(ToolId assembler, ToolId disassembler, string id)
        {
            var spec = new AsmToolchainSpec();
            spec.Assembler = assembler;
            spec.Disassembler = disassembler;
            spec.AsmPath = AsmPath(id);
            spec.BinPath = BinPath(id);
            spec.HexPath = AsmHexPath(id);
            spec.HexArrayPath = HexArrayPath(id);
            spec.ObjKind = ObjFileKind.win64;
            spec.DisasmPath = DisasmPath(id, disassembler);
            spec.Analysis = Analysis();
            spec.ListPath = ListPath(id);
            spec.AsmBitMode = Bitness.b64;
            spec.EmitDebugInfo = true;
            if(spec.ObjKind > ObjFileKind.bin)
                spec.ObjPath = ObjPath(id);

            return spec;
        }

        public AsmToolchainSpec ToolchainSpec(ToolId assembler, ToolId disassembler, FS.FilePath src)
        {
            var spec = new AsmToolchainSpec();
            var id = src.FileName.WithoutExtension.Format();
            spec.Assembler = assembler;
            spec.Disassembler = disassembler;
            spec.AsmPath = src;
            spec.BinPath = BinPath(id);
            spec.HexPath = AsmHexPath(id);
            spec.HexArrayPath = HexArrayPath(id);
            spec.ObjKind = ObjFileKind.win64;
            spec.DisasmPath = DisasmPath(id, disassembler);
            spec.Analysis = Analysis();
            spec.ListPath = ListPath(id);
            spec.AsmBitMode = Bitness.b64;
            spec.EmitDebugInfo = true;
            spec.ObjPath = ObjPath(id);
            return spec;
        }

        string TableId<T>()
            where T : struct
                => Z0.TableId.identify<T>().Identifier.Format();
    }
}