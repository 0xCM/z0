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

        string ITextual.Format()
            => Root.Format();
        Deferred<FS.FilePath> Files()
            => Root.EnumerateFiles(true);

        Deferred<FS.FilePath> Files(FS.FileExt ext)
            => Root.EnumerateFiles(ext, true);
    }
}