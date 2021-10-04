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

        FS.FolderPath Subdir(string name)
            => Root + FS.folder(name);

        FS.FolderPath Subdir(Subject scope)
            => Root + FS.folder(scope.Format());

        FS.FilePath Path(string id, FS.FileExt ext)
            => Root + FS.file(id,ext);

        FS.FilePath Path(Subject scope, string id, FS.FileExt ext)
            => Subdir(scope) + FS.file(id, ext);

        string ITextual.Format()
            => Root.Format();

        Deferred<FS.FilePath> Files()
            => Root.EnumerateFiles(true);

        FS.FolderPath Queries()
            => Root + FS.folder("queries");

        FS.FilePath QueryOut(string id, FS.FileExt ext)
            => Queries() + FS.file(id,ext);

        FS.Files Files(FS.FileExt ext)
            => Root.EnumerateFiles(ext, true).Yield();

        FS.FolderPath Datasets()
            => Root + FS.folder(datasets);

        FS.FolderPath Datasets(Subject scope)
            => Datasets() + FS.folder(scope.Format());

        FS.FolderPath Dataset(Subject scope)
            => Datasets() + FS.folder(scope.Format());

        FS.FilePath TablePath(Subject scope, TableId id)
            => Subdir(scope) + TableFile(id);

        FS.FilePath TablePath(Subject scope, string id)
            => Subdir(scope) + TableName(id);

        FS.FilePath TablePath<T>()
            where T : struct
                => Path(Z0.TableId.identify<T>().Format(), FS.Csv);

        FS.FilePath TablePath<T>(Subject scope)
            where T : struct
                => Subdir(scope) + TableFile<T>();

        FS.FilePath TablePath<T>(Subject scope, string suffix)
            where T : struct
                => Subdir(scope) + TableFile<T>(suffix);
    }
}