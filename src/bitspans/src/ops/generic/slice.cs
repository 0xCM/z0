//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;
    using SB = SpannedBits;

    partial class BitSpans
    {
        /// <summary>
        /// Materializes an integral value from a bitspan segment
        /// </summary>
        /// <param name="src">The source bitspan</param>
        /// <param name="offset">The bit position at which the slice begins</param>
        /// <param name="count">The number of bits, at most bitsize[T], to pull</param>
        /// <typeparam name="T">The integral numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T slice<T>(in BitSpan src, int offset, int count)
            where T : unmanaged
                => slice_u<T>(src,offset,count);

        [MethodImpl(Inline)]
        static T slice_u<T>(in BitSpan src, int offset, int count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(SB.slice(src, w8, offset, count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(SB.slice(src, w16, offset, count));
            else if(typeof(T) == typeof(uint))
                return generic<T>(SB.slice(src, w32, offset, count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(SB.slice(src, w64, offset, count));
            else    
                return slice_i<T>(src,offset,count);
        }
                    
        [MethodImpl(Inline)]
        static T slice_i<T>(in BitSpan src, int offset, int count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(SB.islice(src, w8, offset, count));
            else if(typeof(T) == typeof(short))
                return generic<T>(SB.islice(src, w16, offset,count));
            else if(typeof(T) == typeof(int))
                return generic<T>(SB.islice(src, w32, offset,count));
            else if(typeof(T) == typeof(long))
                return generic<T>(SB.islice(src, w64, offset, count));
            else
                throw Unsupported.define<T>();
        }
    }
}