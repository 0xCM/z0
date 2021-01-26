//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Asm.IceOpKind;

    using W = NumericWidth;

    partial struct IceExtractors
    {
        [Op]
        public static AsmImmInfo imminfo(in IceInstruction src, byte index)
        {
			switch (opkind(src,index))
            {
                case Immediate8:
                    return AsmLang.imminfo((byte)src.Immediate8, true);
                case Immediate8_2nd:
                    return AsmLang.imminfo((byte)src.Immediate8_2nd, true);
                case Immediate16:
                    return AsmLang.imminfo((ushort)src.Immediate16, true);
                case Immediate32:
                    return AsmLang.imminfo((uint)src.Immediate32, true);
                case Immediate64:
                    return AsmLang.imminfo((ulong)src.Immediate64, true);
                case Immediate8to16:
                    return AsmLang.imminfo((short)src.Immediate8to16, false, (W.W8, W.W16));
                case Immediate8to32:
                    return AsmLang.imminfo((int)src.Immediate8to32, false, (W.W8, W.W32));
                case Immediate8to64:
                    return AsmLang.imminfo((long)src.Immediate8to64, false, (W.W8, W.W64));
                case Immediate32to64:
                    return AsmLang.imminfo((int)src.Immediate32to64, false, (W.W32, W.W64));
			}

            return default;
		}
    }
}