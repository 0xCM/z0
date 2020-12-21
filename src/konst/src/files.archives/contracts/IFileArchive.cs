//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static z;

    /// <summary>
    /// Characterizes a file system repository
    /// </summary>
    [Free]
    public interface IFileArchive : IFileExtensions
    {
        FS.FolderPath Root {get;}

        FS.Files Clear(FS.FolderName id)
            => (Root + id).Clear(list<FS.FilePath>()).Array();

        Deferred<FS.FilePath> ArchivedFiles()
            => Root.EnumerateFiles(true);

        FS.Files Clear(string id)
            => Clear(FS.folder(id));

        Deferred<FS.FilePath> Enumerate(FS.FileExt[] ext, bool recurse)
            => Root.EnumerateFiles(ext, recurse);

        Deferred<FS.FilePath> Enumerate(string pattern, bool recurse)
            => Root.EnumerateFiles(pattern, recurse);

        ListedFiles List()
            => FS.list(ArchivedFiles().Array());
    }
}