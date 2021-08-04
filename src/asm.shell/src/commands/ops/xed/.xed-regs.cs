//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".xed-regs")]
        Outcome XedRegs(CmdArgs args)
            => WriteSyms(Xed.Registers());
    }
}