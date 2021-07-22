//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".outdir-list")]
        Outcome DstDirList(CmdArgs args)
        {
            List(OutDir());
            return true;
        }
    }
}