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
        public static m128i<T> For<T>(W128 w, int min, int max, Func<int,T> f)
            where T : unmanaged
        {
            var dst = m128i<T>();
            for(var i=min; i<=max; i++)
                dst.Cell(i) = f(i);
            return dst;
        }

        [MethodImpl(Inline), Op,Closures(Closure)]
        public static m256i<T> For<T>(W256 w, int min, int max, Func<int,T> f)
            where T : unmanaged
        {
            var dst = m256i<T>();
            for(var i=min; i<=max; i++)
                dst.Cell(i) = f(i);
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static __m512i<T> For<T>(W512 w, int min, int max, Func<int,T> f)
            where T : unmanaged
        {
            var dst = m512i<T>();
            for(var i=min; i<=max; i++)
                dst.Cell(i) = f(i);
            return dst;
        }
    }
}