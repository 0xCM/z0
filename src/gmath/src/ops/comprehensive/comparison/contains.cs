//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class gmath
    {
        /// <summary>
        /// Determines whether an interval contains a specified point
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="point">The point to test</param>
        /// <typeparam name="T">The primal numeric type over which the interval is defined</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static bit contains<T>(Interval<T> src, T point)
            where T : unmanaged
        {
            switch(src.Kind)
            {
                case IntervalKind.Closed:
                    return gteq(point, src.Left) && lteq(point, src.Right);
                case IntervalKind.Open:
                    return gt(point, src.Left) && lt(point, src.Right);
                case IntervalKind.LeftClosed:
                    return gteq(point, src.Left) && lt(point, src.Right);
                default:
                    return gt(point, src.Left) && lteq(point, src.Right);
            }
        }

        [MethodImpl(Inline), Op, Closures(UInt32k)]
        public static bit contains<T>(Span<T> xs, T match)
            where T : unmanaged
                => contains(z.first(xs), match, (uint)xs.Length);

        /// <summary>
        ///  Adapted from corefx repo
        /// </summary>
        [MethodImpl(Inline), Op, Closures(UInt32k)]
        public static bit contains<T>(in T src, T match, uint length)
            where T : unmanaged
        {
            var index = 0u;

            while (length >= 8)
            {
                length -= 8;
                if(test8(src, match, index))
                    return true;
                index += 8;
            }

            if (length >= 4)
            {
                length -= 4;
                if(test4(src, match, index))
                    return true;
                index += 4;
            }

            while (length > 0)
            {
                length -= 1;
                if (eq(match, z.add(src, index)))
                    return true;
                index += 1;
            }
            return false;
        }

        [MethodImpl(Inline), Op, Closures(UInt32k)]
        static bit test8<T>(in T src, T match, uint index)
            where T : unmanaged
                =>  eq(match, z.add(src, index + 0)) ||
                    eq(match, z.add(src, index + 1)) ||
                    eq(match, z.add(src, index + 2)) ||
                    eq(match, z.add(src, index + 3)) ||
                    eq(match, z.add(src, index + 4)) ||
                    eq(match, z.add(src, index + 5)) ||
                    eq(match, z.add(src, index + 6)) ||
                    eq(match, z.add(src, index + 7)
                    );

        [MethodImpl(Inline), Op, Closures(UInt32k)]
        static bit test4<T>(in T src, T match, uint index)
            where T : unmanaged
                =>  eq(match, z.add(src, index + 0)) ||
                    eq(match, z.add(src, index + 1)) ||
                    eq(match, z.add(src, index + 2)) ||
                    eq(match, z.add(src, index + 3));

    }
}