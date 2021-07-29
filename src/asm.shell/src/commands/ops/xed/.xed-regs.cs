//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".xed-regs")]
        Outcome XedRegs(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = Xed.Registers();
            WriteSyms(src);
            return result;
        }
    }
}