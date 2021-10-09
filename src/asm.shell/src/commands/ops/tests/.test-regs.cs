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

            var machine = RegMachines.intel64();
            var buffer = text.buffer();
            RegMachines.state(machine,buffer);
            Write(buffer.Emit());

            return result;
        }
    }
}