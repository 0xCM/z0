//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;

    using static Konst;
    using static memory;

    partial struct Bytes
    {
        [MethodImpl(Inline), Op]
        public static byte inc(byte x)
            => (byte)(++x);

        [MethodImpl(Inline), Op]
        public static byte dec(byte x)
            => (byte)(--x);

        [MethodImpl(Inline), Op]
        public static byte sll(byte x, byte count)
            => (byte)(x << count);

        [MethodImpl(Inline), Op]
        public static byte srl(byte x, byte count)
            => (byte)(x >> count);

        [MethodImpl(Inline), Op]
        public static byte add(byte a, byte b)
            => (byte)(a + b);

        [MethodImpl(Inline), Op]
        public static byte sub(byte a, byte b)
            => (byte)(a - b);

        [MethodImpl(Inline), Op]
        public static byte and(byte a, byte b)
            => (byte)(a & b);

        [MethodImpl(Inline), Op]
        public static byte or(byte a, byte b)
            => (byte)(a | b);

        [MethodImpl(Inline), Op]
        public static bool gt(byte a, byte b)
            => a > b;

        [MethodImpl(Inline), Op]
        public static bool gteq(byte a, byte b)
            => a >= b;

        [MethodImpl(Inline), Op]
        public static bool lt(byte a, byte b)
            => a < b;

        [MethodImpl(Inline), Op]
        public static bool lteq(byte a, byte b)
            => a <= b;

        [MethodImpl(Inline), Op]
        public static bool eq(byte a, byte b)
            => a == b;

        [MethodImpl(Inline), TestZ]
        public static bool testz(in byte A, in byte B)
            => z.testz(read8(A), read8(B));

        [MethodImpl(Inline), TestC]
        public static bool testc(in byte A, in byte B)
            => z.testc(read8(A),read8(B));

        [MethodImpl(Inline), TestC]
        public static bool testc(in byte A)
            => z.testc(read8(A));                       
    }
}