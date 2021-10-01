//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".test-regs")]
        Outcome TestRegs(CmdArgs args)
        {
            var result = Outcome.Success;

            var machine = RegMachine.intel64();
            var buffer = text.buffer();
            machine.State(buffer);
            Write(buffer.Emit());

            return result;
        }


        Outcome TestRegOps(CmdArgs args)
        {
            var result = Outcome.Success;



            return result;
        }
    }
}