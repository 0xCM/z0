//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IBuildArchive : IFileArchive<BuildArchive>
    {
        FS.FolderPath From(string path)
            => FS.dir(path);
        FS.FolderPath NetCoreApp(string version)
            => Root + FS.folder($"netcoreapp{version}");

        FS.FolderPath NetCoreWin64(string version)
            => NetCoreApp(version) + FS.folder("win-x64");
    }
}