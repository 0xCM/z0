//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Vdsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Intrinsics
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref m128i<T> src, int i)
            where T : unmanaged
        {
            ref var dst = ref @as<m128i<T>,T>(src);
            return ref seek(dst,i);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref m256i<T> src, int i)
            where T : unmanaged
        {
            ref var dst = ref @as<m256i<T>,T>(src);
            return ref seek(dst,i);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref __m512i<T> src, int i)
            where T : unmanaged
        {
            ref var dst = ref @as<__m512i<T>,T>(src);
            return ref seek(dst,i);
        }

        [MethodImpl(Inline), Closures(Closure)]
        public static m128i<T> m128i<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Closures(Closure)]
        public static m256i<T> m256i<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Closures(Closure)]
        public static __m512i<T> m512i<T>()
            where T : unmanaged
                => default;

        public static m128i<byte> z128i(W8 w)
            => default;

        public static m128i<sbyte> z128i(W8i w)
            => default;

        public static m128i<ushort> z128i(W16 w)
            => default;

        public static m128i<uint> z128i(W32 w)
            => default;

        public static m128i<ulong> z128i(W64 w)
            => default;

        public static m256i<byte> z256i(W8 w)
            => default;

        public static __m512i<byte> z512i(W8 w)
            => default;
     }
}