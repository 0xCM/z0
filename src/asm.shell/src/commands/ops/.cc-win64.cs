//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;

    partial class AsmCmdService
    {
        [CmdOp(".cc-win64")]
        Outcome WinCC(CmdArgs args)
        {
            var result = Outcome.Success;

            var cc = CallCv.Win64;
            Write("win64cc");
            Write("---------------");
            var cc8 = CallCv.regslots(cc,w8);
            Write(cc8.Format());

            var cc16 = CallCv.regslots(cc,w16);
            Write(cc16.Format());

            var cc32 = CallCv.regslots(cc,w32);
            Write(cc32.Format());

            var cc64 = CallCv.regslots(cc,w64);
            Write(cc64.Format());

            return result;
        }
    }
}