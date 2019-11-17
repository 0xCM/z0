//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;
    using static AsIn;

    partial class bvoc
    {
        public static int pop_bitstore(ulong src)
            => Bits.popbs(src);

        public static void part64x1_byte(ulong src, Span<byte> dst)
            => BitParts.part64x1(src, dst);

        public static void part64x1_bit(ulong src, Span<bit> dst)
            => BitParts.part64x1(src, dst);

        public static uint pop3x256(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z)
            => Bits.pop(x,y,z);

        public static uint pop3x128(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z)
            => Bits.pop(x,y,z);

        public static uint pop3x64(ulong x, ulong y, ulong z)
            => Bits.pop(x,y,z);


    }

}