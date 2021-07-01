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

        public FS.FolderPath AsmSources()
            => Root + FS.folder("asm");

        public FS.FolderPath Labs()
            => AsmSources() + FS.folder(labs);

        public FS.FolderPath Models()
            => AsmSources() + FS.folder(models);

        public FS.FilePath SourceCode(string id, bool model)
            => model ? Models() + FS.file(id, FS.Asm) : Labs() + FS.file(id, FS.Asm);

        public FS.FolderPath DocRoot()
            => Root + FS.folder(docs);

        public FS.FolderPath DataRoot()
            => Root + FS.folder(data);

        public FS.FolderPath Datasets()
            => DataRoot() + FS.folder(datasets);

        public FS.FilePath DataFile(string id, FS.FileExt ext)
            => Datasets() + FS.file(id,ext);

        public FS.FolderPath Dataset(string id)
            => Datasets() + FS.folder(id);

        public FS.FolderPath DumpBinOutDir()
            => Output() + FS.folder("dumpbin") + FS.folder(output);

        public FS.FolderPath Bin()
            => Output() + FS.folder(bin);

        public FS.FolderPath Scripts()
            => Root + FS.folder(scripts);

        public FS.FolderPath Tables()
            => DataRoot() + FS.folder(tables);

        public FS.FilePath Table(string id, FS.FileExt ext)
            => Tables() + FS.file(id,ext);

        public FS.FilePath Table<T>()
            where T : struct, IRecord<T>
                => Tables() + FS.file(TableId.identify<T>().Format(), FS.Csv);

        public FS.FilePath Script(string id)
            => Scripts() + FS.file(id, FS.Cmd);

        public FS.FolderPath RefDocs()
            => DocRoot() + FS.folder(refs);

        public FS.FilePath RefDoc(string docid, FS.FileExt ext)
            => RefDocs() + FS.file(docid, ext);

        public FS.FolderPath DocExtracts()
            => DocRoot() + FS.folder(extracts);

        public FS.FolderPath DataSources()
            => DataRoot() + FS.folder(sources);

        public FS.FolderPath DataSource(string id)
            => DataSources() + FS.folder(id);

        public FS.FilePath InstInfo(string id)
            => Dataset("instructions") + FS.file(id,FS.Csv);

        public FS.FolderPath DocExtractDir(string docid)
            => DocExtracts() + FS.folder(docid);

        public FS.FilePath DocExtract(string docid, string part, FS.FileExt ext)
            => DocExtractDir(docid) + FS.file(string.Format("{0}.{1}",docid, part), ext);

        public FS.FolderPath Disasm()
            => Output() + FS.folder("dis");

        public FS.FolderPath RawDisasm()
            => Disasm() + FS.folder("raw");

        public FS.FolderPath ImportedDisasm()
            => Disasm() + FS.folder("imported");

        public FS.FolderPath Analysis()
            => Output() + FS.folder("analysis");

        public FS.FolderPath Logs()
            => Output() + FS.folder("log");

        public FS.FolderPath Obj()
            => Output() + FS.folder(obj);

        public FS.FolderPath Control()
            => Output() + FS.folder(".cmd");

        public FS.FolderPath External()
            => Root + FS.folder(external);

        public FS.FilePath BinPath(string id)
            =>  Bin() + FS.file(id, FS.Bin);

        public FS.FolderPath Lists()
            => Output() + FS.folder("list");

        public FS.FilePath ObjPath(string id)
            => Obj() + FS.file(id,FS.Obj);

        public FS.FilePath ListPath(string id)
            => Lists() + FS.file(id, FS.ext("list.asm"));

        public FS.FilePath RawDisasmPath(string id, ToolId tool, FS.FileExt? ext = null)
            => RawDisasm() + FS.file(string.Format("{0}.{1}", id, tool), ext ?? FS.Asm);

        public FS.FilePath ImportedDisasmPath(string id, ToolId tool, FS.FileExt? ext = null)
            => RawDisasm() + FS.file(string.Format("{0}.{1}", id, tool), ext ?? FS.Asm);

        public AsmToolchainSpec ToolchainSpec(ToolId assembler, ToolId disassembler, string id, bool model = true)
        {
            var spec = new AsmToolchainSpec();
            spec.Assembler = assembler;
            spec.Disassembler = disassembler;
            spec.AsmPath = SourceCode(id, model);
            spec.BinPath = BinPath(id);
            spec.ObjKind = ObjFileKind.win64;
            if(spec.ObjKind > ObjFileKind.bin)
                spec.ObjPath = ObjPath(id);
            spec.RawDisasmPath = RawDisasmPath(id, disassembler);
            spec.Analysis = Analysis();
            spec.ListPath = ListPath(id);
            spec.AsmBitMode = Bitness.b64;
            return spec;
        }
    }
}