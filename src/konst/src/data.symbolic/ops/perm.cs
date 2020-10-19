//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

     using static Konst;
     using static LetterTypes;
     using static PermLits;
     using static z;

    partial struct Symbolic
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void apply<T>(ReadOnlySpan<T> src, ReadOnlySpan<Swap> swaps, Span<T> dst)
            where T : unmanaged
        {
            var len = swaps.Length;
            ref readonly var input = ref first(src);
            ref readonly var exchange = ref first(swaps);
            for(var k = 0u; k<len; k++)
            {
                ref readonly var x = ref skip(exchange, k);
                refswap(ref seek(input, x.i), ref seek(input, x.j));
            }
        }

        /// <summary>
        /// Computes the digits corresponding to each 4-bit segment of the permutation spec as
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> digits(Perm16 spec)
            => vshuf16x8(z.vinc<byte>(n128), spec.data);

        /// <summary>
        /// Computes the digits corresponding to each 5-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> digits(Perm32 spec)
            => vshuf32x8(z.vinc<byte>(n256),spec.data);

        [MethodImpl(Inline), Op]
        public static Perm4L perm(A a, B b, C c, D d)
            => Perm4L.ABCD;

        [MethodImpl(Inline), Op]
        public static Perm4L perm(A a, B b,  D d, C c)
            => Perm4L.ABDC;

        [MethodImpl(Inline), Op]
        public static Perm4L perm(A a, C c, B b,  D d)
            => Perm4L.ACBD;

        [MethodImpl(Inline), Op]
        public static Perm8L permid(N8 n)
            => Perm8Identity;

        [MethodImpl(Inline), Op]
        public static Perm16L permid(N16 n)
            => Perm16Identity;

        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline), Op]
        public static bool test(Perm4L src)
            => (byte)src <= 3;

        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline), Op]
        public static bool test(Perm8L src)
            => (uint)src <= 7;

        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline), Op]
        public static bool test(Perm16L src)
            => (ulong)src <= 15;
    }
}