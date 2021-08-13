//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmOperands;

    partial class AsmCmdService
    {
        [CmdOp(".asm-regs")]
        Outcome ShowAsmRegs(CmdArgs args)
        {
            var result = Outcome.Success;
            xmm r = AsmRegOps.xmm0;
            var counter = 0;
            while(counter++ < 36)
            {
                Write(r++);
            }

            return result;
        }
    }
}