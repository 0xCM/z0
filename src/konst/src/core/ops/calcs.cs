//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct core
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

        [MethodImpl(Inline), Op]
        public static byte xor(byte a, byte b)
            => (byte)(a ^ b);

        [MethodImpl(Inline), Op]
        public static byte or(byte a, byte b, byte c)
            => (byte)(a | b | c);

        [MethodImpl(Inline), Op]
        public static byte or(byte a, byte b, byte c, byte d)
            => (byte)(a | b | c | d);

        [MethodImpl(Inline), Op]
        public static byte or(byte a, byte b, byte c, byte d, byte e)
            => (byte)(a | b | c | d | e); 
    }
}