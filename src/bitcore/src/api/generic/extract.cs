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

    partial class gbits
    {
        /// <summary>
        /// Extracts a contiguous range of source bits beginning at a specified index
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit position  within the source where extraction should begin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline), Extract, Closures(Integers)]
        public static T extract<T>(T src, byte start, byte length)
            where T : unmanaged
                => extract_u(src,start,length);

        /// <summary>
        /// Extracts a contiguous range of source per the extract specifier
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The selection specifier</param>
        [MethodImpl(Inline), Extract, Closures(Integers)]
        public static T extract<T>(T src, BitExtractSpec spec)
            where T : unmanaged
                => extract_u(src, spec);

        [MethodImpl(Inline)]
        static T extract_u<T>(T lhs, byte start, byte length)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.extract(uint8(lhs), start, length));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.extract(uint16(lhs), start, length));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.extract(uint32(lhs), start, length));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.extract(uint64(lhs), start, length));
            else
                return extract_i(lhs,start,length);
        }

        [MethodImpl(Inline)]
        static T extract_i<T>(T lhs, byte start, byte length)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.extract(int8(lhs), start, length));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.extract(int16(lhs), start, length));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.extract(int32(lhs), start, length));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.extract(int64(lhs), start, length));
            else
                throw no<T>();
        }


        [MethodImpl(Inline)]
        static T extract_u<T>(T lhs, BitExtractSpec spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.extract(uint8(lhs), spec));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.extract(uint16(lhs), spec));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.extract(uint32(lhs), spec));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.extract(uint64(lhs), spec));
            else
                return extract_i(lhs,spec);
        }

        [MethodImpl(Inline)]
        static T extract_i<T>(T lhs, BitExtractSpec spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.extract(int8(lhs), spec));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.extract(int16(lhs), spec));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.extract(int32(lhs), spec));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.extract(int64(lhs), spec));
            else
                throw no<T>();
        }
    }
}