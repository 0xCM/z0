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

    partial class gbits
    {
        /// <summary>
        /// Enables a contiguous sequence of source bits starting at a specified index
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="index">The index at which to begin</param>
        /// <param name="count">The number of bits to fill</param>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T fill<T>(T src, byte index, byte count)
            where T : unmanaged
                => fill_u(src,index,count);

        [MethodImpl(Inline)]
        static T fill_u<T>(T src, byte index, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.fill(uint8(src), index, count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.fill(uint16(src), index, count));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.fill(uint32(src), index, count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.fill(uint64(src), index, count));
            else
                return fill_i(src,index,count);
        }

        [MethodImpl(Inline)]
        static T fill_i<T>(T src, byte index, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.fill(int8(src), index, count));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.fill(int16(src), index, count));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.fill(int32(src), index, count));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.fill(int64(src), index, count));
            else
                throw Unsupported.define<T>();
        }
   }
}