//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".sources")]
        Outcome Sources(CmdArgs args)
        {
            Write(SouceWs().Root);
            return true;
        }
    }
}