//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IFileArchiveMonitor : IMonitor<FS.FolderPath>
    {
        FS.FolderPath ArchiveRoot {get;}

        FS.FolderPath IMonitor<FS.FolderPath>.Subject
            => ArchiveRoot;
    }
}