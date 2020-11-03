//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    [StructLayout(LayoutKind.Sequential), Cmd]
    public struct EmitFileListCmd : ICmdSpec<EmitFileListCmd>
    {
        public string ListName;

        public FS.FolderPath SourceDir;

        public FS.FileExt[] FileKinds;

        public bool FileUriMode;

        public FS.FilePath TargetPath;

        public uint EmissionLimit;
    }
}