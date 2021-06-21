//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static EnvFolders;

    public readonly struct AsmWorkspace : IFileArchive
    {
        [MethodImpl(Inline)]
        public static AsmWorkspace create(FS.FolderPath root)
            => new AsmWorkspace(root);

        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        AsmWorkspace(FS.FolderPath root)
        {
            Root = root;
        }

        public FS.FolderPath Output()
            => Root + FS.folder(".output");

        public FS.FolderPath Source()
            => Root + FS.folder("asm");

        public FS.FolderPath DocRoot()
            => Root + FS.folder(docs);

        public FS.FolderPath DumpBinOutDir()
            => Output() + FS.folder("dumpbin") + FS.folder(output);

        public FS.FolderPath Bin()
            => Output() + FS.folder(bin);

        public FS.FolderPath Scripts()
            => Root + FS.folder("scripts");

        public FS.FilePath Script(string id)
            => Scripts() + FS.file(id,FS.Cmd);

        public FS.FolderPath RefDocs()
            => DocRoot() + FS.folder(refs);

        public FS.FilePath RefDoc(string docid, FS.FileExt ext)
            => RefDocs() + FS.file(docid, ext);

        public FS.FolderPath DocExtracts()
            => DocRoot() + FS.folder(extracts);

        public FS.FolderPath DocExtractDir(string docid)
            => DocExtracts() + FS.folder(docid);

        public FS.FilePath DocExtract(string docid, string part, FS.FileExt ext)
            => DocExtractDir(docid) + FS.file(string.Format("{0}.{1}",docid, part), ext);

        public FS.FolderPath Disassembly()
            => Output() + FS.folder("dis");

        public FS.FolderPath Analysis()
            => Output() + FS.folder("analysis");

        public FS.FolderPath Logs()
            => Output() + FS.folder("log");

        public FS.FolderPath Control()
            => Output() + FS.folder(".cmd");

        public FS.FolderPath External()
            => Root + FS.folder(external);

        public FS.FilePath SourcePath(string id)
            => Source() + FS.file(id, FS.Asm);

        public FS.FilePath BinPath(string id)
            =>  Bin() + FS.file(id, FS.Bin);

        public FS.FilePath DisasmPath(string id, ToolId tool, FS.FileExt? ext = null)
            => Disassembly() + FS.file(string.Format("{0}.{1}", id, tool), ext ?? FS.Asm);

        public AsmToolchainSpec ToolchainSpec(ToolId assembler, ToolId disassembler, string id)
        {
            var spec = new AsmToolchainSpec();
            spec.Assembler = assembler;
            spec.Disassembler = disassembler;
            spec.AsmPath = SourcePath(id);
            spec.BinPath = BinPath(id);
            spec.DisasmPath = DisasmPath(id, disassembler);
            spec.Analysis = Analysis();
            return spec;
        }
    }
}