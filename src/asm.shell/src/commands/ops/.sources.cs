//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".sources")]
        Outcome ShowSources(CmdArgs args)
        {
            Write(Sources().Root);
            return true;
        }
    }
}