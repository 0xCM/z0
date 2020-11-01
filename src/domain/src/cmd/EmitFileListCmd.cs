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

    partial class XCmdFactory
    {
        public static ref EmitFileListCmd WithKinds(this ref EmitFileListCmd cmd, params FS.FileExt[] ext)
        {
            cmd.FileKinds = ext;
            return ref cmd;
        }

        public static ref EmitFileListCmd LimitEmissions(this ref EmitFileListCmd cmd, uint max)
        {
            cmd.EmissionLimit = max;
            return ref cmd;
        }
    }
}