//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

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

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static bit contains<T>(Span<T> xs, T match)  
            where T : unmanaged       
            => contains(ref head(xs), match, xs.Length);

        /// <summary>
        ///  Adapted from corefx repo
        /// </summary>
        [Op, Closures(UnsignedInts)]
        public static bit contains<T>(ref T src, T match, int length)
            where T : unmanaged
        {
            IntPtr index = (IntPtr)0;

            while (length >= 8)
            {
                length -= 8;

                if (eq(match, offset(ref src, index + 0)) ||
                    eq(match, offset(ref src, index + 1)) ||
                    eq(match, offset(ref src, index + 2)) ||
                    eq(match, offset(ref src, index + 3)) ||
                    eq(match, offset(ref src, index + 4)) ||
                    eq(match, offset(ref src, index + 5)) ||
                    eq(match, offset(ref src, index + 6)) ||
                    eq(match, offset(ref src, index + 7)))
                return true;
                
                index += 8;
            }

            if (length >= 4)
            {
                length -= 4;

                if (eq(match, offset(ref src, index + 0)) ||
                    eq(match, offset(ref src, index + 1)) ||
                    eq(match, offset(ref src, index + 2)) ||
                    eq(match, offset(ref src, index + 3)))
                return true;

                index += 4;
            }

            while (length > 0)
            {
                length -= 1;

                if (eq(match, offset(ref src, index)))
                    return true;

                index += 1;
            }
            return false;        
        }  
    }
}