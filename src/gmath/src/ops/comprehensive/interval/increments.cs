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
        /// Populates a span of length n with consecutive values 0,1,...n - 1
        /// </summary>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The target value type</typeparam>    
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> increments<T>(Span<T> dst)
            where T : unmanaged
        {
            var count = dst.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = convert<T>(i);
            return dst;
        }

        /// <summary>
        /// Populates a memory target with values first, first + 1, ... first + (n - 1)
        /// </summary>
        /// <param name="first">The first value</param>
        /// <param name="count">The number of values to populate</param>
        /// <param name="dst">The target memory reference</param>
        /// <typeparam name="T">The target value type</typeparam>    
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void increments<T>(T first, uint count, ref T dst)
            where T : unmanaged
        {
            for(var i=0; i<count; i++)
                seek(dst,i) = add(first, convert<T>(i));
        }

        /// <summary>
        /// Emits a monotonic integral sequence with a specified number of terms to a target reference
        /// </summary>
        /// <param name="count">The number of terms to populate</param>
        /// <param name="dst">The target reference</param>
        /// <typeparam name="T">The sequence term type</typeparam>    
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void increments<T>(uint count, ref T dst)
            where T : unmanaged
        {
            for(var i=0; i<count; i++)
                seek(dst,i) = convert<T>(i);
        }

        /// <summary>
        /// Produces a monotonic sequence k, k + 1, ... k + (N - 1) where N denoties the length of the target
        /// </summary>
        /// <param name="k">The value of the first term</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The target value type</typeparam>    
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void increments<T>(T k, Span<T> dst)
            where T : unmanaged
                => increments(k, (uint)dst.Length, ref first(dst));
    }
}