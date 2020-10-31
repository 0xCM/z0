//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IFileArchive : IFileArchivePaths
    {
        IEnumerable<FS.FilePath> Files(bool recurse, params FS.FileExt[] ext)
            => Root.EnumerateFiles(recurse, ext);

        IEnumerable<FS.FilePath> Files(string pattern, bool recurse)
            => Root.EnumerateFiles(pattern, recurse);

        IEnumerable<FS.FilePath> Files()
            => Root.EnumerateFiles(true);

        IEnumerable<FS.FilePath> Files(FS.FileExt ext)
            => Root.EnumerateFiles(ext, true);
    }

    [Free]
    public interface IFileArchive<H> : IFileArchive
        where H : IFileArchive<H>
    {

    }
}