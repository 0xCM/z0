//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a file system repository
    /// </summary>
    [Free]
    public interface IFileArchive : ITextual
    {
        FS.FolderPath Root {get;}

        FS.FolderPath Subdir(string name)
            => Root + FS.folder(name);

        string ITextual.Format()
            => Root.Format();

        Deferred<FS.FilePath> Files()
            => Root.EnumerateFiles(true);

        Deferred<FS.FilePath> Files(FS.FileExt ext)
            => Root.EnumerateFiles(ext, true);

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
    }
}