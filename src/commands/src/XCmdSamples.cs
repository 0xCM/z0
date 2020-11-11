//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost(ApiNames.XCmdSamples)]
    public static partial class XCmdCSamples
    {
        public static EmitFileListCmd EmitFileListCmdSample(this IWfShell wf)
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
}