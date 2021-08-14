//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    public interface IAsmWorkspace : IWorkspace
    {
        FS.FolderPath DisasmOut()
            => OutDir() + FS.folder("dis");

        FS.FolderPath Lists()
            => OutDir() + FS.folder("list");

        /// <summary>
        /// Defines a path of the form {Root}/src
        /// </summary>
        FS.FolderPath Src()
            => Root + FS.folder(src);

        /// <summary>
        /// Defines a path of the form {Src}/asm
        /// </summary>
        FS.FolderPath AsmLibSrc()
            => Src() + FS.folder("asm");

        FS.FolderPath AsmAppSrc()
            => Src() + FS.folder("apps");

        FS.FilePath AsmPath(string id)
            => AsmLibSrc() + FS.file(id, FS.Asm);

        FS.FolderPath Analysis()
            => OutDir() + FS.folder("analysis");

        FS.FolderPath DumpOut()
            => OutDir() + FS.folder(dumps);

        FS.FilePath AsmHexPath(string id)
            => HexDir() + FS.file(id, FS.Hex);

        FS.FilePath HexArrayPath(string id)
            => HexDir() + FS.file(string.Format("{0}.array",id), FS.Hex);

        FS.FilePath ListPath(string id)
            => Lists() + FS.file(id, FS.AsmList);

        FS.FilePath DisasmPath(string id, ToolId tool, FS.FileExt? ext = null)
            => DisasmOut() + FS.file(string.Format("{0}.{1}", id, tool), ext ?? FS.Asm);

        AsmToolchainSpec ToolchainSpec(ToolId assembler, ToolId disassembler, string id)
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

        AsmToolchainSpec ToolchainSpec(ToolId assembler, ToolId disassembler, FS.FilePath src)
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
    }
}