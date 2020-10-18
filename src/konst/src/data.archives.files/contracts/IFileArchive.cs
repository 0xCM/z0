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

        IEnumerable<FS.FolderPath> Directories()
            => ApiFiles.directories(Root, true);

        IEnumerable<FS.FilePath> Files()
            => ApiFiles.files(Root, true);

        IEnumerable<FS.FilePath> Files(FS.FileExt ext)
            => ApiFiles.files(Root, true);

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