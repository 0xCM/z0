//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Asm.IceOpKind;

    using W = NumericWidth;

    partial struct IceConverters
    {
        [Op]
        public static AsmImmInfo imminfo(in IceInstruction src, byte index)
        {
			switch (opkind(src,index))
            {
                case Immediate8:
                    return AsmCore.imm((byte)src.Immediate8, true);
                case Immediate8_2nd:
                    return AsmCore.imm((byte)src.Immediate8_2nd, true);
                case Immediate16:
                    return AsmCore.imm((ushort)src.Immediate16, true);
                case Immediate32:
                    return AsmCore.imm((uint)src.Immediate32, true);
                case Immediate64:
                    return AsmCore.imm((ulong)src.Immediate64, true);
                case Immediate8to16:
                    return AsmCore.imm((short)src.Immediate8to16, false, (W.W8, W.W16));
                case Immediate8to32:
                    return AsmCore.imm((int)src.Immediate8to32, false, (W.W8, W.W32));
                case Immediate8to64:
                    return AsmCore.imm((long)src.Immediate8to64, false, (W.W8, W.W64));
                case Immediate32to64:
                    return AsmCore.imm((int)src.Immediate32to64, false, (W.W32, W.W64));
			}

            return default;
		}
    }
}