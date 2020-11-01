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

        public static EmitFileListCmd sample(IWfShell wf)
        {
            var cmd = new EmitFileListCmd();
            cmd.ListName = "tests";
            cmd.SourceDir = FS.dir(@"J:\lang\net\runtime\artifacts\tests\coreclr\Windows_NT.x64.Debug");
            cmd.TargetPath = wf.Db().JobPath(FS.file("coreclr.tests", ArchiveFileKinds.Cmd));
            cmd.FileUriMode = false;
            cmd.WithKinds(ArchiveFileKinds.Cmd);
            cmd.LimitEmissions(20);
            return cmd;
        }
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