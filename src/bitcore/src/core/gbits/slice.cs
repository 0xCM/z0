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

    partial class gbits
    {
        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should begin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline), Slice, Closures(Integers)]
        public static T slice<T>(T src, byte start, byte length)
            where T : unmanaged
                => slice_u(src,start,length);
            
        [MethodImpl(Inline)]
        static T slice_i<T>(T lhs, byte start, byte length)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.slice(int8(lhs), start, length));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.slice(int16(lhs), start, length));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.slice(int32(lhs), start, length));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.slice(int64(lhs), start, length));
            else
                throw Unsupported.define<T>();
        }           

        [MethodImpl(Inline)]
        static T slice_u<T>(T lhs, byte start, byte length)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.slice(uint8(lhs), start, length));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.slice(uint16(lhs), start, length));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.slice(uint32(lhs), start, length));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.slice(uint64(lhs), start, length));
            else
                return slice_i(lhs,start,length);
        }           
    }
}