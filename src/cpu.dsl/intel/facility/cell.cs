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

    partial struct Intel
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref num<T> cell<T>(ref __m128i<T> src, int i)
            where T : unmanaged
        {
            ref var dst = ref @as<__m128i<T>,num<T>>(src);
            return ref seek(dst,i);
        }

        public static __m128i<T> z128<T>()
            where T : unmanaged
                => default;

        public static __m128i<byte> z128(W8 w)
            => default;

        [MethodImpl(Inline), Closures(AllNumeric)]
        public static void For(int min, int max, Func<int,int> ixf, Action<int> receiver)
        {
            for(var i=min; i<=max; i++)
            {
                var j = ixf(i);
                receiver(j);

            }
        }

        [MethodImpl(Inline), Closures(AllNumeric)]
        public static __m128i<T> For<T>(W128 w, int min, int max, Func<int,T> f)
            where T : unmanaged
        {
            var dst = z128<T>();
            for(var i=min; i<=max; i++)
                dst[i] = f(i);
            return dst;
        }
    }
}