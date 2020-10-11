//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IFileArchive
    {
        FS.FolderPath Root {get;}

        IEnumerable<FS.FolderPath> Directories(bool recurse = true)
            => FileArchives.directories(Root, recurse);

        IEnumerable<FS.FilePath> Files(bool recurse = true)
            => FileArchives.files(Root, recurse);

        IEnumerable<FS.FilePath> Files(FS.FileExt ext, bool recurse = true)
            => FileArchives.files(Root, recurse);

    }

    public interface IFileArchive<H> : IFileArchive
        where H : IFileArchive<H>
    {

    }

    public interface IFileArchive<H,F> : IFileArchive<H>
        where H : IFileArchive<H>
    {
        IEnumerable<F> Query();
    }
}