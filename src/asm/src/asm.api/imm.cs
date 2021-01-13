//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Asm.IceOpKind;

    using W = NumericWidth;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmImmInfo imminfo(byte value, bool direct)
            => new AsmImmInfo(W.W8, value, direct);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo imminfo(short value, bool direct, Sx sek)
            => new AsmImmInfo(W.W16, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo imminfo(ushort value, bool direct)
            => new AsmImmInfo(W.W16, value, direct);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo imminfo(int value, bool direct, Sx sek)
            => new AsmImmInfo(W.W32, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo imminfo(uint value, bool direct)
            => new AsmImmInfo(W.W32, value, direct);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo imminfo(long value, bool direct, Sx sek)
            => new AsmImmInfo(W.W64, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo imminfo(ulong value, bool direct)
            => new AsmImmInfo(W.W64, value, direct);

        [Op]
        public static AsmImmInfo imminfo(in IceInstruction src, byte index)
        {
			switch (opkind(src,index))
            {
                case Immediate8:
                    return asm.imminfo((byte)src.Immediate8, true);
                case Immediate8_2nd:
                    return asm.imminfo((byte)src.Immediate8_2nd, true);
                case Immediate16:
                    return asm.imminfo((ushort)src.Immediate16, true);
                case Immediate32:
                    return asm.imminfo((uint)src.Immediate32, true);
                case Immediate64:
                    return asm.imminfo((ulong)src.Immediate64, true);
                case Immediate8to16:
                    return asm.imminfo((short)src.Immediate8to16, false, (W.W8, W.W16));
                case Immediate8to32:
                    return asm.imminfo((int)src.Immediate8to32, false, (W.W8, W.W32));
                case Immediate8to64:
                    return asm.imminfo((long)src.Immediate8to64, false, (W.W8, W.W64));
                case Immediate32to64:
                    return asm.imminfo((int)src.Immediate32to64, false, (W.W32, W.W64));
			}

            return default;
		}
    }
}