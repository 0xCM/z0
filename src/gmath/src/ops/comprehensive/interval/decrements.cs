//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class gmath
    {
        /// <summary>
        /// Populates a memory target with consecutive values count-1, count - 2, ..., 0
        /// </summary>
        /// <param name="count">The number of values to populate</param>
        /// <param name="dst">The target memory reference</param>
        /// <typeparam name="T">The target value type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void decrements<T>(int count, ref T dst)
            where T : unmanaged
        {
            for(var i=0; i<count; i++)
                seek(dst,i) = z.force<T>(i);
        }

        /// <summary>
        /// Populates a memory target with consecutive values first, first - 1, ... first - (n - 1)
        /// </summary>
        /// <param name="first">The first value</param>
        /// <param name="count">The number of values to populate</param>
        /// <param name="dst">The target memory reference</param>
        /// <typeparam name="T">The target value type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void decrements<T>(T first, int count, ref T dst)
            where T : unmanaged
        {
            for(var i=0; i<count; i++)
                seek(dst,i) = gmath.sub(first, z.force<T>(i));
        }

        /// <summary>
        /// Populates a span with consecutive values first, first - 1, ... first - (n - 1)
        /// </summary>
        /// <param name="first">The first value</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The target value type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void decrements<T>(T lead, Span<T> dst)
            where T : unmanaged
                => decrements(lead, dst.Length, ref first(dst));
    }
}