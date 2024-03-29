//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    public struct ClCmdInfo
    {
        public ClrAssemblyName AssemblyName;

        public FS.FolderPath NetHostPath;

        public FS.FolderPath PlatformPath;

        public string Source;

        public string OutputName;

        public FS.FilePath OutputPath;

        public string RuntimeID;

        public string Architecture;

        public string Configuration;

        public string CommandOverride;

        public Index<FS.FolderPath> UserIncludes;
    }
}