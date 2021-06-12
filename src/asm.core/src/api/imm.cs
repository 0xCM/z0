//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using W = NumericWidth;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static ImmInfo imm(byte value, bool direct)
            => new ImmInfo(W.W8, value, direct);

        [MethodImpl(Inline), Op]
        public static ImmInfo imm(short value, bool direct, Sx sek)
            => new ImmInfo(W.W16, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static ImmInfo imm(ushort value, bool direct)
            => new ImmInfo(W.W16, value, direct);

        [MethodImpl(Inline), Op]
        public static ImmInfo imm(int value, bool direct, Sx sek)
            => new ImmInfo(W.W32, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static ImmInfo imm(uint value, bool direct)
            => new ImmInfo(W.W32, value, direct);

        [MethodImpl(Inline), Op]
        public static ImmInfo imm(long value, bool direct, Sx sek)
            => new ImmInfo(W.W64, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static ImmInfo imm(ulong value, bool direct)
            => new ImmInfo(W.W64, value, direct);
    }
}