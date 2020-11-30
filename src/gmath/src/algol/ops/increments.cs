//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static gmath;
    using static z;

    partial struct Algorithmic
    {
        public static Span<T> increments<T>(ClosedInterval<T> src)
            where T : unmanaged
        {
            var min = src.Min;
            var max = src.Max;
            var count = src.Width + 1;
            Span<T> dst = sys.alloc<T>(src.Width + 1);
            increments(src,dst);
            return dst;
        }

        [Op, Closures(UnsignedInts)]
        public static void increments<T>(ClosedInterval<T> src, Span<T> dst)
            where T : unmanaged
        {
            var min = src.Min;
            var max = src.Max;
            var count = src.Width + 1;
            var index = 0u;
            var current = min;
            while(lteq(current,max) && index < count)
            {
                seek(dst, index++) = current;
                if(lt(current, max))
                    current = inc(current);
                else
                    break;
            }
        }
    }
}