//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static As;
    using static AsIn;

    partial class gbits
    {
        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should begin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static T bitslice<T>(T src, byte start, byte length)
            where T : unmanaged
                => bitslice_u(src,start,length);
            
        [MethodImpl(Inline)]
        static T bitslice_i<T>(T lhs, byte start, byte length)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.bitslice(int8(lhs), start, length));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.bitslice(int16(lhs), start, length));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.bitslice(int32(lhs), start, length));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.bitslice(int64(lhs), start, length));
            else
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        static T bitslice_u<T>(T lhs, byte start, byte length)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.bitslice(uint8(lhs), start, length));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.bitslice(uint16(lhs), start, length));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.bitslice(uint32(lhs), start, length));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.bitslice(uint64(lhs), start, length));
            else
                return bitslice_i(lhs,start,length);
        }           
    }
}