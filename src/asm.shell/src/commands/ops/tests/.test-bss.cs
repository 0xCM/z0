//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".test-bss")]
        Outcome TestBss(CmdArgs args)
        {
            var result = Outcome.Success;

            Bss.dispense(0, out var entry);

            Write(entry.Capacity());
            var machine = Machines.machine(n8, entry);

            return result;
       }
    }
}
