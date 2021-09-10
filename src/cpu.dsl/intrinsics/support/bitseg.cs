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
        public static ref T bitseg<T>(ref __m128i<T> src, int max, int min)
            where T : unmanaged
        {
            ref var cells = ref @as<__m128i<T>,T>(src);
            var width = max - min + 1;
            var offset = min/8;
            var length = width/8;
            ref var start = ref seek(cells, offset);
            ref var cell = ref first(cover(start, length));
            return ref cell;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T bitseg<T>(ref __m256i<T> src, int max, int min)
            where T : unmanaged
        {
            ref var cells = ref @as<__m256i<T>,T>(src);
            var width = max - min + 1;
            var offset = min/8;
            var length = width/8;
            ref var start = ref seek(cells, offset);
            ref var cell = ref first(cover(start, length));
            return ref cell;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T bitseg<T>(ref __m512i<T> src, int max, int min)
            where T : unmanaged
        {
            ref var cells = ref @as<__m512i<T>,T>(src);
            var width = max - min + 1;
            var offset = min/8;
            var length = width/8;
            ref var start = ref seek(cells, offset);
            ref var cell = ref first(cover(start, length));
            return ref cell;
        }
    }
}