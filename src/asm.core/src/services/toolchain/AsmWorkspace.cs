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
        const string instructions = nameof(instructions);

        const string analysis = nameof(analysis);

        const string intrinsics = nameof(intrinsics);

        const string alg = nameof(alg);

        [MethodImpl(Inline)]
        public static AsmWorkspace create(FS.FolderPath root)
            => new AsmWorkspace(root);

        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        AsmWorkspace(FS.FolderPath root)
        {
            Root = root;
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
            if(id == Toolsets.bddiasm)
                return FS.path(@"j:\source\bddisasm\build\bddisasm.exe");
            else if(id == Toolsets.nasm)
                return FS.path(@"c:\tools\nasm\nasm.exe");
            else
                throw no(id);
        }

        /// <summary>
        /// Defines a path of the form {Root}/.out
        /// </summary>
        public FS.FolderPath Output()
            => Root + FS.folder(dotout);

        /// <summary>
        /// Defines a path of the form {Root}/asm
        /// </summary>
        public FS.FolderPath AsmSources()
            => Root + FS.folder("asm");

        /// <summary>
        /// Defines a path of the form {Root}/cpp
        /// </summary>
        public FS.FolderPath CppSources()
            => Root + FS.folder(cpp);

        public FS.FolderPath AsmLabs()
            => AsmSources() + FS.folder(labs);

        public FS.FolderPath AsmModels()
            => AsmSources() + FS.folder(models);

        public FS.FilePath AsmSource(string id, bool model)
            => model ? AsmModels() + FS.file(id, FS.Asm) : AsmLabs() + FS.file(id, FS.Asm);

        public FS.FolderPath Settings()
            => DataRoot() + FS.folder(settings);

        public FS.FilePath Settings(string id, FS.FileExt ext)
            => Settings() + FS.file(id,ext);

        public FS.FolderPath DocRoot()
            => Root + FS.folder(docs);

        public FS.FolderPath DataRoot()
            => Root + FS.folder(data);

        /// <summary>
        /// Defines a path of the form {CodeGenRoot} := {DataRoot}/codegen
        /// </summary>
        public FS.FolderPath CodeGenRoot()
            => Root + FS.folder(codegen);

        /// <summary>
        /// Defines a path of the form {CodeGenRoot}/{id}
        /// </summary>
        /// <param name="dataset">A code gnerateion set identifier</param>
        public FS.FolderPath CodeGenDir(string id)
            => CodeGenRoot() + FS.folder(id);

        /// <summary>
        /// Defines a path of the form {CodeGenRoot}/{dir}/{id}.{ext}
        /// </summary>
        /// <param name="dir">A generation set identifier</param>
        /// <param name="id">A file identifiere</param>
        /// <param name="ext">The target language extension</param>
        public FS.FilePath Generated(string dir, string id, FS.FileExt ext)
            => CodeGenDir(dir) + FS.file(id,ext);

        /// <summary>
        /// Defines a path of the form {ImportRoot} := {DataRoot}/imported
        /// </summary>
        public FS.FolderPath ImportRoot()
            => DataRoot() + FS.folder(imported);

        /// <summary>
        /// Defines a path of the form {EtlLogRoot} := {DataRoot}/logs
        /// </summary>
        public FS.FolderPath EtlLogs()
            => DataRoot() + FS.folder(logs);

        /// <summary>
        /// Defines a path of the form {EtlLogRoot}/{dataset}
        /// </summary>
        /// <param name="dataset">A dataset identifier</param>
        public FS.FolderPath EtlLogs(string dataset)
            => EtlLogs() + FS.folder(dataset);

        /// <summary>
        /// Defines a path of the form {EtlLogRoot}/common/{id}.log
        /// </summary>
        /// <param name="id">A file identifier</param>
        public FS.FilePath EtlLog(string id)
            => EtlLogs(common) + FS.file(id, FS.Log);

        /// <summary>
        /// Defines a path of the form {EtlLogRoot}/{dataset}/{file}
        /// </summary>
        /// <param name="id">A file identifier</param>
        public FS.FilePath EtlLog(string dataset, FS.FileName file)
            => EtlLogs(dataset) + file;

        /// <summary>
        /// Defines a path of the form {EtlLogRoot}/common/{id}.{ext}
        /// </summary>
        /// <param name="id">A file identifier</param>
        /// <param name="ext">A file extension</param>
        public FS.FilePath EtlLog(string id, FS.FileExt ext)
            => EtlLogs(common) + FS.file(id, ext);

        /// <summary>
        /// Defines a path of the form {EtlLogRoot}/{Dataset}/{id}.log
        /// </summary>
        /// <param name="dataset">The dataset identiier</param>
        /// <param name="id">The file identifier</param>
        public FS.FilePath EtlLog(string dataset, string id)
            => EtlLogs(dataset) + FS.file(id, FS.Log);

        /// <summary>
        /// Defines a path of the form {EtlLogRoot}/{Dataset}/{id}.{ext}
        /// </summary>
        /// <param name="dataset">A dataset identiier</param>
        /// <param name="id">A file identifier</param>
        /// <param name="ext">Z file extension</param>
        public FS.FilePath EtlLog(string dataset, string id, FS.FileExt ext)
            => EtlLogs(dataset) + FS.file(id, ext);

        /// <summary>
        /// Defines a path of the form {ImportRoot}/{dataset}
        /// </summary>
        /// <param name="dataset">A dataset identiier</param>
        public FS.FolderPath ImportDir(string dataset)
            => ImportRoot() + FS.folder(dataset);

        public FS.FilePath ImportPath(string id, FS.FileExt ext)
            => ImportRoot() + FS.file(id,ext);

        public FS.FilePath ImportPath(string dir, string id, FS.FileExt ext)
            => ImportDir(dir) + FS.file(id,ext);

        /// <summary>
        /// Defines a path of the form {DataRoot}/datasets
        /// </summary>
        public FS.FolderPath Datasets()
            => DataRoot() + FS.folder(datasets);

        public FS.FilePath DataFile(string id, FS.FileExt ext)
            => Datasets() + FS.file(id,ext);

        public FS.FolderPath Dataset(string id)
            => Datasets() + FS.folder(id);

        /// <summary>
        /// Defines a path of the form {Output}/bin
        /// </summary>
        public FS.FolderPath Bin()
            => Output() + FS.folder(bin);

        /// <summary>
        /// Defines a path of the form {Root}/scripts
        /// </summary>
        public FS.FolderPath Scripts()
            => Root + FS.folder(scripts);

        public FS.FolderPath Tables()
            => DataRoot() + FS.folder(tables);

        public FS.FilePath Table(string id, FS.FileExt ext)
            => Tables() + FS.file(id,ext);

        public FS.FilePath ImportTable<T>()
            where T : struct, IRecord<T>
                => ImportRoot() + FS.file(TableId<T>(), FS.Csv);

        public FS.FilePath ImportTable<T>(string dataset)
            where T : struct, IRecord<T>
                => ImportDir(dataset) + FS.file(TableId<T>(), FS.Csv);

        public FS.FilePath Script(string id)
            => Scripts() + FS.file(id, FS.Cmd);

        public FS.FolderPath RefDocs()
            => DocRoot() + FS.folder(refs);

        public FS.FolderPath RefDocs(string id)
            => RefDocs() + FS.folder(id);

        public FS.FolderPath DocExtracts()
            => DocRoot() + FS.folder(extracts);

        public FS.FolderPath DataSources()
            => DataRoot() + FS.folder(sources);

        public FS.FolderPath DataSource(string id)
            => DataSources() + FS.folder(id);

        public FS.FilePath InstInfo(string id)
            => Dataset(instructions) + FS.file(id,FS.Csv);

        public FS.FolderPath DocExtractDir(string docid)
            => DocExtracts() + FS.folder(docid);

        public FS.FilePath DocExtract(string docid, string part, FS.FileExt ext)
            => DocExtractDir(docid) + FS.file(string.Format("{0}.{1}",docid, part), ext);

        public FS.FolderPath DisasmOut()
            => Output() + FS.folder("dis");

        public FS.FolderPath RawDisasm()
            => DisasmOut() + FS.folder("raw");

        public FS.FolderPath ImportedDisasm()
            => DisasmOut() + FS.folder(imported);

        public FS.FolderPath IntrinsicImportDir()
            => ImportRoot() + FS.folder(intrinsics);

        public FS.FolderPath AlgImportDir()
            => ImportRoot() + FS.folder(string.Format("{0}.{1}", intrinsics, alg));

        public ReadOnlySpan<FS.FilePath> AlgImportPaths(string match)
            => AlgImportDir().Files(FS.Alg).Where(f => f.Contains(match));

        public FS.FolderPath Analysis()
            => Output() + FS.folder(analysis);

        public FS.FolderPath OutLogs()
            => Output() + FS.folder(logs);

        public FS.FolderPath ImportLogs()
            => ImportRoot() + FS.folder(logs);

        public FS.FolderPath ObjOut()
            => Output() + FS.folder(obj);

        public FS.FolderPath DumpOut()
            => Output() + FS.folder(dumps);

        public FS.FolderPath ExeOut()
            => Output() + FS.folder(exe);

        public FS.FolderPath External()
            => Root + FS.folder(external);

        public FS.FilePath BinPath(string id)
            =>  Bin() + FS.file(id, FS.Bin);

        public FS.FolderPath Lists()
            => Output() + FS.folder("list");

        public FS.FolderPath Bitfields()
            => DataRoot() + FS.folder(bitfields);

        public FS.FilePath Bitfield(string id)
            => Bitfields() + FS.file(id, FS.ext("bits"));

        public FS.FilePath ObjPath(string id)
            => ObjOut() + FS.file(id,FS.Obj);

        public FS.FilePath ListPath(string id)
            => Lists() + FS.file(id, FS.AsmList);

        public FS.FilePath RawDisasmPath(string id, ToolId tool, FS.FileExt? ext = null)
            => RawDisasm() + FS.file(string.Format("{0}.{1}", id, tool), ext ?? FS.Asm);

        public FS.FilePath ImportedDisasmPath(string id, ToolId tool, FS.FileExt? ext = null)
            => RawDisasm() + FS.file(string.Format("{0}.{1}", id, tool), ext ?? FS.Asm);

        public AsmToolchainSpec ToolchainSpec(ToolId assembler, ToolId disassembler, string id, bool model = true)
        {
            var spec = new AsmToolchainSpec();
            spec.Assembler = assembler;
            spec.Disassembler = disassembler;
            spec.AsmPath = AsmSource(id, model);
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

        string TableId<T>()
            where T : struct, IRecord<T>
                => Z0.TableId.identify<T>().Identifier.Format();
    }
}