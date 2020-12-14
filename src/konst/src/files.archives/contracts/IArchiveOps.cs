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
    public interface IArchiveOps : IFileArchive
    {
        FS.Files Clear(FS.FolderName id);

        FS.Files Clear(string id);

        IEnumerable<FS.FolderPath> Directories()
        {
            foreach(var path in Root.SubDirs(true))
                yield return FS.dir(path.Name);
        }
    }
}