//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath EtlRoot()
            => DbRoot() + FS.folder(etl);

        FS.FolderPath EtlRoot(FS.FolderPath root)
            => DbRoot(root) + FS.folder(etl);

        FS.FolderPath EtlLogRoot()
            => LogRoot() + FS.folder(etl);

        FS.FolderPath EtlLogRoot(FS.FolderPath root)
            => LogRoot(root) + FS.folder(etl);

        FS.FolderPath EtlDir(string subject)
            => EtlRoot() + FS.folder(subject);

        FS.FolderPath EtlDir(FS.FolderPath root, string subject)
            => EtlRoot(root) + FS.folder(subject);

        FS.FolderPath EtlTableRoot()
            => EtlDir(tables);

        FS.FolderPath EtlTableRoot(FS.FolderPath root)
            => EtlDir(root, tables);

        FS.FilePath EtlLog(string name)
            => EtlLogRoot() + FS.file(name, FS.Log);

        FS.FilePath EtlLog(FS.FolderPath root, string name)
            => EtlLogRoot(root) + FS.file(name, FS.Log);

        FS.FilePath EtlFile(string subject, FS.FileName file)
            => EtlDir(subject) + file;

        FS.FilePath EtlTable<T>(string id)
            where T : struct, IRecord<T>
                => EtlTableRoot() + TableFileName<T>(id);

        FS.FilePath EtlTable<T>(FS.FolderPath root, string id)
            where T : struct, IRecord<T>
                => EtlTableRoot(root) + TableFileName<T>(id);
    }
}