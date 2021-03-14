//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static DbNames;

    partial interface IEnvPaths
    {
        FS.FolderPath CaseRoot()
            => DbRoot() + FS.folder(cases);

        FS.FolderPath CaseSourceRoot()
            => CaseRoot() + FS.folder(sources);

        FS.FolderPath CaseSource(string id)
            => CaseSourceRoot() + FS.folder(id);

        FS.FilePath CaseSourcePath(string id, FS.FileName file)
            => CaseSource(id) + file;

        FS.FolderPath CaseTargetRoot()
            => CaseRoot() + FS.folder(targets);

        FS.FolderPath CaseTarget(string id)
            => CaseTargetRoot() + FS.folder(id);

        FS.FilePath CaseTargetPath(string id, FS.FileName file)
            => CaseTarget(id) + file;

        FS.FolderPath TestLogRoot()
            => LogRoot() + FS.folder(tests);

        FS.FolderPath TestLogDir(PartId id)
            => TestLogRoot() + FS.folder(id.Format());

        FS.FolderPath TestLogDir(FS.FolderName folder)
            => TestLogRoot() + folder;

        FS.FolderPath SortedCaseLogRoot()
            => TestLogRoot();

        FS.FilePath SortedCaseLogPath()
            => SortedCaseLogRoot() + FS.file(AppName, Csv);
    }
}