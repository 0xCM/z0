//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class XTend
    {
        public static AsmWorkspace AsmWorkspace(this IEnvContext context)
            => Z0.AsmWorkspace.create(context.Env.AsmWorkspace);
    }


    public readonly struct AsmWorkspace : IFileArchive
    {
        [MethodImpl(Inline)]
        public static AsmWorkspace create(FS.FolderPath root)
            => new AsmWorkspace(root);

        [MethodImpl(Inline)]
        AsmWorkspace(FS.FolderPath root)
        {
            Root = root;
        }

        public FS.FolderPath Root {get;}


        public FS.FolderPath Builds
            => Root + FS.folder(".build");

        public FS.FolderPath Source
            => Root + FS.folder("asm");

        public FS.FolderPath Bin
            => Builds + FS.folder("bin");

        public FS.FolderPath Disassembly
            => Builds + FS.folder("dis");

        public FS.FolderPath Control
            => Builds + FS.folder(".cmd");

        public FS.FolderPath External
            => Root + FS.folder("external");

        public FS.FilePath SourcePath(string id)
            => Source + FS.file(id, FS.Asm);

        public FS.FilePath BinPath(string id)
            =>  Bin + FS.file(id, FS.Bin);

        public FS.FilePath DisasmPath(string id, ToolId tool, FS.FileExt? ext = null)
            => Disassembly + FS.file(string.Format("{0}.{1}", id, tool), ext ?? FS.Asm);

        public AsmToolchainSpec ToolchainSpec(ToolId assembler, ToolId disassembler, string id)
        {
            var spec = new AsmToolchainSpec();
            spec.Assembler = assembler;
            spec.Disassembler = disassembler;
            spec.AsmPath = SourcePath(id);
            spec.BinPath = BinPath(id);
            spec.DisasmPath = DisasmPath(id, disassembler);
            return spec;
        }
    }
}