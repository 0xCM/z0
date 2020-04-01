//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Core;
    using static CastNumeric;

    partial class gmath
    {
        /// <summary>
        /// Populates a memory target with consecutive values 0,1,...count-1
        /// </summary>
        /// <param name="count">The number of values to populate</param>
        /// <param name="dst">The target memory reference</param>
        /// <typeparam name="T">The target value type</typeparam>    
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static void increments<T>(int count, ref T dst)
            where T : unmanaged
        {
            for(var i=0; i<count; i++)
                seek(ref dst,i) = convert<T>(i);
        }

        /// <summary>
        /// Populates a span of length n with consecutive values 0,1,...n - 1
        /// </summary>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The target value type</typeparam>    
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Span<T> increments<T>(Span<T> dst)
            where T : unmanaged
        {
            var count = dst.Length;
            for(var i=0; i<count; i++)
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
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static void increments<T>(T first, int count, ref T dst)
            where T : unmanaged
        {
            for(var i=0; i<count; i++)
                seek(ref dst,i) = gmath.add(first, convert<T>(i));
        }

        /// <summary>
        /// Populates a span with values first, first + 1, ... first + (n - 1)
        /// </summary>
        /// <param name="first">The first value</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The target value type</typeparam>    
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static void increments<T>(T first, Span<T> dst)
            where T : unmanaged
                => increments(first, dst.Length, ref head(dst));
    }
}