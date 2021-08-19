//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static EnvFolders;

    /// <summary>
    /// Characterizes a file system repository
    /// </summary>
    [Free]
    public interface IFileArchive : ITextual, ITablePaths
    {
        FS.FolderPath Root {get;}

        FS.FolderName PartFolder(PartId id)
            => FS.folder(id.Format());

        FS.FileName HostFile(ApiHostUri host, FS.FileExt ext)
            => FS.file(string.Format("{0}.{1}", host.Part.Format(), host.HostName), ext);

        FS.FolderPath Subdir(string name)
            => Root + FS.folder(name);

        FS.FilePath Path(string id, FS.FileExt ext)
            => Root + FS.file(id,ext);

        FS.FilePath Path(Scope scope, string id, FS.FileExt ext)
            => Subdir(scope) + FS.file(id, ext);

        FS.FolderPath Subdir(Scope scope)
            => Root + FS.folder(scope.Format());
        string ITextual.Format()
            => Root.Format();

        Deferred<FS.FilePath> Files()
            => Root.EnumerateFiles(true);

        FS.FolderPath Queries()
            => Root + FS.folder("queries");

        FS.FolderPath Queries(Scope scope)
            => Queries() + FS.folder(scope.Format());

        FS.FilePath QueryOut(string id, FS.FileExt ext)
            => Queries() + FS.file(id,ext);

        Deferred<FS.FilePath> Files(FS.FileExt ext)
            => Root.EnumerateFiles(ext, true);

        FS.FolderPath Datasets()
            => Root + FS.folder(datasets);

        FS.FolderPath Datasets(Scope scope)
            => Datasets() + FS.folder(scope.Format());

        FS.FolderPath Dataset(Scope scope)
            => Datasets() + FS.folder(scope.Format());

        FS.FilePath DataSource(Scope scope, string id, FS.FileExt ext)
            => Datasets(scope) + FS.file(id,ext);

        FS.FilePath Table(Scope scope, TableId id)
            => Subdir(scope) + TableName(id);

        FS.FilePath Table(Scope scope, TableId id, string suffix)
            => Subdir(scope) + TableName(id,suffix);

        FS.FilePath Table<T>(FS.FileExt ext)
            where T : struct
                => Path(Z0.TableId.identify<T>().Format(), ext);

        FS.FilePath Table<T>()
            where T : struct
                => Path(Z0.TableId.identify<T>().Format(), FS.Csv);

        FS.FilePath Table<T>(Scope scope)
            where T : struct
                => Subdir(scope) + TableName<T>();

        FS.FilePath Table<T>(Scope scope, string suffix)
            where T : struct
                => Subdir(scope) + TableName<T>(suffix);
    }
}