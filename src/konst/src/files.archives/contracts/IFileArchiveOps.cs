//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IFileArchiveOps : IFileArchive
    {
       Option<FilePath> Deposit<F,R,S>(R[] src, string id, S subject, FS.FileExt type)
            where F : unmanaged, Enum
            where R : struct, ITabular;

        Files Clear(FS.FolderName id);

        Files Clear(string id);

        IEnumerable<FS.FolderPath> Directories()
        {
            foreach(var path in Root.SubDirs(true))
                yield return FS.dir(path.Name);
        }
    }
}