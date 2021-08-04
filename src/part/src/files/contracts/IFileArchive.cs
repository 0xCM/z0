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
    public interface IFileArchive : ITextual
    {
        FS.FolderPath Root {get;}

        FS.FilePath Settings(string id, FS.FileExt ext)
            => Root + FS.folder("settings") + FS.file(id, ext);

        FS.FolderPath Subdir(string name)
            => Root + FS.folder(name);

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

        FS.FolderPath Dataset(Scope scope)
            => Datasets() + FS.folder(scope.Format());

        /// <summary>
        /// Defines a path of the form {Root}/{subdir}/{id}.{ext}
        /// </summary>
        /// <param name="subdir">A subdirectory identifier</param>
        /// <param name="id">A file identifiere</param>
        /// <param name="ext">The target extension</param>
        FS.FilePath Path(string subdir, string id, FS.FileExt ext)
            => Subdir(subdir) + FS.file(id,ext);

        /// <summary>
        /// Defines a path of the form {Root}/{id}.{ext}
        /// </summary>
        /// <param name="id">A file identifiere</param>
        /// <param name="ext">The target extension</param>
        FS.FilePath Path(string id, FS.FileExt ext)
            => Root + FS.file(id,ext);

        FS.FilePath Table(Scope scope, TableId id)
            => Subdir(scope) + TableName(id);

        FS.FilePath Table(Scope scope, TableId id, string suffix)
            => Subdir(scope) + TableName(id,suffix);

        FS.FilePath Table(TableId id)
            => Root + TableName(id);

        FS.FileName TableName(TableId id)
            => FS.file(id.Format(), FS.Csv);

        FS.FileName TableName(TableId id, string suffix)
            => FS.file(string.Format("{0}.{1}", id, suffix), FS.Csv);

        FS.FilePath Table<T>(FS.FileExt ext)
            where T : struct, IRecord<T>
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

        FS.FileName TableName<T>()
            where T : struct
                => FS.file(Z0.TableId.identify<T>().Format(), FS.Csv);

        FS.FileName TableName<T>(string suffix)
            where T : struct
                => TableName(Z0.TableId.identify<T>(), suffix);
    }
}