//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IArchiveMonitor : IMonitor<FS.FolderPath>
    {
        FS.FolderPath ArchiveRoot {get;}

        FS.FolderPath IMonitor<FS.FolderPath>.Subject
            => ArchiveRoot;
    }
}