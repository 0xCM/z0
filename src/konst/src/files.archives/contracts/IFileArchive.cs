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

        IEnumerable<FS.FilePath> Files()
            => Root.EnumerateFiles(true);

        IEnumerable<FS.FilePath> Files(bool recurse, params FS.FileExt[] ext)
            => Root.EnumerateFiles(recurse, ext);

        IEnumerable<FS.FilePath> Files(string pattern, bool recurse)
            => Root.EnumerateFiles(pattern, recurse);

        ListedFiles Listing()
            => FS.list(Files().Array());
    }
}