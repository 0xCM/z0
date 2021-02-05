//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct Intervals
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        static ulong left<T>(in ClosedInterval<T> src)
            where T : unmanaged
                => uint64(src.Min);

        [MethodImpl(Inline)]
        static ulong right<T>(in ClosedInterval<T> src)
            where T : unmanaged
                => uint64(src.Max);

        /// <summary>
        /// Computes the points that determine a partitioning predicated on partition width
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="width">The partition width</param>
        [MethodImpl(Inline), Op]
        public static ulong[] partition(in ClosedInterval<ulong> src, ulong width)
        {
            var dst = alloc<ulong>((src.Width/width) + 1);
            partition(src.Min,src.Max, width, dst);
            return dst;
        }

        public static string format<T>(ClosedIntervals<T> src)
            where T : unmanaged
        {
            var dst = text.buffer();
            dst.Append("<<");
            for(var i=0u; i<src.SegCount; i++)
                dst.Append(src.Range(i).Format());
            dst.Append(">>");
            return dst.Emit();
        }

        /// <summary>
        /// Computes a sequence of points that partitions an integral range
        /// </summary>
        /// <param name="min">The lower bound</param>
        /// <param name="min">The upper bound</param>
        /// <param name="width">The partition width</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void partition(ulong min, ulong max, ulong width, ulong[] dst)
        {
            var points = span(dst);
            var count = points.Length;
            var point = min;
            var final = count - 1;

            for(var i=0u; i<count; i++)
            {
                if(i == 0)
                    seek(points,i) = min;
                else if(i == final - 1)
                    seek(points,i) = max;
                else
                    seek(points,i) = point;

                if(i != final)
                    point = add(point, width);
            }
        }
    }
}