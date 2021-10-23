//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using static WsAtoms;

    public class LlvmPaths : WsService<LlvmPaths>
    {
        IProjectWs LlvmData;

        protected override void Initialized()
        {
            LlvmData = Ws.Project("llvm.data");
        }

        public FS.FolderPath ImportRoot()
            => LlvmData.Subdir(imports);

        public FS.FolderPath ImportTables()
            => ImportRoot() + FS.folder(tables);

        public FS.FolderPath ImportDir(string scope)
            => ImportRoot() + FS.folder(scope);

        public FS.FolderPath ImportTables(string scope)
            => ImportTables() + FS.folder(scope);

        public FS.FolderPath ListImportTables()
            => ImportTables("lists");

        public FS.Files ListImportFiles()
            => ListImportTables().Files(FS.Csv);

        public FS.FilePath ListImportPath(string id)
            => ListImportTables() + FS.file(id, FS.Csv);

        public FS.FilePath TableGenSource(string id)
            => LlvmData.OutDir() + FS.file(id, FS.Txt);

        public FS.FolderPath TableGenImports()
            => ImportRoot() + FS.folder("tablegen");

        public FS.FolderPath ListSources()
            => LlvmData.OutDir() + FS.folder(lists);

        public FS.Files ListSourceFiles()
            => ListSources().Files(FS.List);

        public FS.FolderPath CodeGenRoot()
            => LlvmData.Subdir("codegen");

        public FS.FilePath CodeGenPath(string id, FS.FileExt ext)
            => CodeGenRoot() + FS.folder("stringtables") + FS.file(id,ext);

        public FS.FilePath TableGenImport(string id, FS.FileExt ext)
            =>  TableGenImports() + FS.file(id, ext);

        public FS.FilePath ImportMap(string id)
            => ImportRoot() + FS.file(id, FS.ext("map"));

        public FS.FilePath ImportTable<T>()
            where T : struct
                => ImportTables() + Tables.filename<T>();

        public FS.FilePath ImportTable(string id)
            => ImportTables() + FS.file(id, FS.Csv);
    }
}