//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.InteropServices;

    using static Root;

    partial class AsmCmdService
    {
        public Outcome AsmAnd(CmdArgs args)
        {
            var result = Outcome.Success;

            const byte BaseCode = 0x20;

            return result;
        }

        /// <summary>
        /// AND(m8, r8) = 20 /r
        /// encode(0) = ModRM:reg(r, w)
        /// encode(1) = ModRM:r/m(r)
        /// </summary>
        [CmdOp(".asm-and")]
        public Outcome AsmAnd_m8xr8(CmdArgs args)
        {
            var result = Outcome.Success;
            const byte BaseCode = 0x20;


            return result;
        }

    }
}