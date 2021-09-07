//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static Ccv;


    partial class AsmCmdService
    {
        [CmdOp(".cc-win64")]
        Outcome WinCC(CmdArgs args)
        {
            var result = Outcome.Success;

            Write("win64cc");
            Write("---------------");
            var cc8 = Win64.slots(w8);
            Write(cc8.Format());

            var cc16 = Win64.slots(w16);
            Write(cc16.Format());

            var cc32 = Win64.slots(w32);
            Write(cc32.Format());

            var cc64 = Win64.slots(w64);
            Write(cc64.Format());

            return result;
        }
    }
}