//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using static Part;

    public struct WinSdkInfo
    {
        public string Version;

        public Index<FS.FolderPath> IncPaths;

        public Index<FS.FolderPath> LibPaths;
    }
}