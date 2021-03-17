//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;

    [PrefixCodes]
    public enum BndPrefixCode : byte
    {
        None = 0,

        [PrefixCode]
        BND = xf2
    }

/*
—
BND prefix is encoded using F2H if the following conditions are true:
• CPUID.(EAX=07H, ECX=0):EBX.MPX[bit 14] is set.
• BNDCFGU.EN and/or IA32_BNDCFGS.EN is set.
• When the F2 prefix precedes a near CALL, a near RET, a near JMP, a short Jcc, or a near Jcc instruction
*/

}