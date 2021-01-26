//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using W = NumericWidth;

    partial struct AsmLang
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

    }
}