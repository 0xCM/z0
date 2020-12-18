//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;

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

        FS.Files Clear(string id)
            => Clear(FS.folder(id));

        IEnumerable<FS.FolderPath> Directories()
        {
            foreach(var path in Root.SubDirs(true))
                yield return FS.dir(path.Name);
        }

        Deferred<FS.FilePath> Files()
            => Root.EnumerateFiles(true);

        Deferred<FS.FilePath> Files(FS.FileExt[] ext, bool recurse)
            => Root.EnumerateFiles(ext, recurse);

        Deferred<FS.FilePath> Files(string pattern, bool recurse)
            => Root.EnumerateFiles(pattern, recurse);

        ListedFiles Listing()
            => FS.list(Files().Array());
    }
}