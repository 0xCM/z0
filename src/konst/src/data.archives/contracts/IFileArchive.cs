//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using api = Archives;

    public interface IFileArchive
    {
        FS.FolderPath Root {get;}

        IEnumerable<FS.FolderPath> Directories(bool recurse = true)
            => api.dir(Root, recurse);

        IEnumerable<FS.FilePath> Files(bool recurse = true)
            => api.files(Root, recurse);

        IEnumerable<FS.FilePath> Files(FS.FileExt ext, bool recurse = true)
            => api.files(Root, recurse);

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