//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".srcdir-list")]
        Outcome SrcDirList(CmdArgs args)
        {
            List(SrcDir());
            return true;
        }
    }
}