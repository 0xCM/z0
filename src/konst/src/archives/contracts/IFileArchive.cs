//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Reflection;

    using static Konst;
    using static z;

    public interface IFileArchive
    {
        FS.FolderPath Root {get;}


        IEnumerable<FS.FolderPath> Directories(bool recurse = true)
        {
            foreach(var path in Root.SubDirs(recurse))
            {
                yield return FS.dir(path.Name);
            }
        }

        IEnumerable<FS.FilePath> Files(bool recurse = true)
        {
            foreach(var path in Root.Files(recurse))
            {
                yield return FS.path(path.Name);
            }

        }

        IEnumerable<FS.FilePath> Files(FS.FileExt ext, bool recurse = true)
        {
            foreach(var path in Root.Files(ext, recurse))
            {
                yield return FS.path(path.Name);
            }
        }

    }

    public interface IFileArchive<H> : IFileArchive
        where H : IFileArchive<H>
    {

    }
}