//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public sealed class WinCmdShell : Interpreter<WinCmdShell>
    {
        protected override FS.FilePath ExePath
            => FS.file("cmd", ArchiveFileKinds.Exe).ToPath();
    }
}