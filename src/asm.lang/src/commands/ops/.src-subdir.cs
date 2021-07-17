//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".src-subdir")]
        Outcome SrcSubDir(CmdArgs args)
        {
            var folder = FS.folder(arg(args,0).Value);
            Write(SrcDir(SrcDir() + folder));
            return true;
        }
    }
}