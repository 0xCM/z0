//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed;

    partial class XTend
    {
        /// <summary>
        /// Determines whether an interval contains a specified point
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="point">The point to test</param>
        /// <typeparam name="T">The primal numeric type over which the interval is defined</typeparam>
        [MethodImpl(Inline)]
        public static bool Contains<T>(this Interval<T> src, T point)
            where T : unmanaged
                => gmath.contains(src,point);

        /// <summary>
        /// Creates the same kind of interval with alternate endpoints
        /// </summary>
        /// <param name="left">The left endpoint</param>
        /// <param name="right">The right endpoint</param>
        [MethodImpl(Inline)]
        internal static S WithEndpoints<S,T>(this S src, T left, T right)
            where S : struct, IInterval<S,T>
            where T : unmanaged, IComparable<T>, IEquatable<T>
                => default(S).New(left, right, src.Kind);


        /// <summary>
        /// Returns 1 if the left and right spans contain identical content and 0 otherwise
        /// </summary>
        /// <param name="xs">The left span</param>
        /// <param name="ys">The right span</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit Identical<T>(this Span<T> xs, Span<T> ys)  
            where T : unmanaged       
                => gmath.identical(xs,ys);

        /// <summary>
        /// Returns 1 if the left and right spans contain identical content and 0 otherwise
        /// </summary>
        /// <param name="xs">The left span</param>
        /// <param name="ys">The right span</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit Identical<T>(this ReadOnlySpan<T> xs, ReadOnlySpan<T> ys)  
            where T : unmanaged       
                => gmath.identical(xs,ys);

        /// <summary>
        /// Determines whether any elements of the source match the target
        /// </summary>
        /// <param name="src">The source values</param>
        /// <param name="target">The target value to match</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static bool Contains<T>(this ReadOnlySpan<T> src, T target)        
            where T : unmanaged
                => src.BinarySearch(target, gmath.comparer<T>()) >= 0;

    }

}