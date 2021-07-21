//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".dst-subdir")]
        Outcome DstSubDir(CmdArgs args)
        {
            var folder = FS.folder(arg(args,0).Value);
            Write(OutDir(OutDir() + folder));
            return true;
        }
    }
}