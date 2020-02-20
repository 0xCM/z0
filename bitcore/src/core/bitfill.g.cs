//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {    
        /// <summary>
        /// Enables a contiguous sequence of source bits starting at a specified index
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="index">The index at which to begin</param>
        /// <param name="count">The number of bits to fill</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static T bitfill<T>(T src, byte index, byte count)
            where T : unmanaged
                => bitfill_u(src,index,count);

        [MethodImpl(Inline)]
        static T bitfill_u<T>(T src, byte index, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.bitfill(uint8(src), index, count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.bitfill(uint16(src), index, count));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.bitfill(uint32(src), index, count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.bitfill(uint64(src), index, count));
            else
                return bitfill_i(src,index,count);
        }

        [MethodImpl(Inline)]
        static T bitfill_i<T>(T src, byte index, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.bitfill(int8(src), index, count));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.bitfill(int16(src), index, count));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.bitfill(int32(src), index, count));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.bitfill(int64(src), index, count));
            else
                throw unsupported<T>();
        }
   }
}