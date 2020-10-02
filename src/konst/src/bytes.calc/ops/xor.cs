//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static memory;

    partial struct Bytes
    {
        [MethodImpl(Inline), Xor]
        public static byte xor(byte a, byte b)
            => (byte)(a ^ b);

        [MethodImpl(Inline), Xor]
        public static void xor(in byte A, in byte B, ref byte Z)
            => store8(xor(read8(A), read8(B)), ref Z);
    }
}