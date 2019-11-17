//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {
        
        /// <summary>
        /// Projects a contiguous sequence of bits from a source value into a target value
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="srcOffset">The source offset index</param>
        /// <param name="len">The number of bits in the sequence</param>
        /// <param name="dstOffset">The target offset index</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static ref T bitmap<T>(T src, byte srcOffset, byte len,  byte dstOffset, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                bitmapu(src,srcOffset,len,dstOffset, ref dst);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                bitmapi(src,srcOffset,len,dstOffset, ref dst);
            else 
                bitmapf(src,srcOffset,len,dstOffset, ref dst);
            
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref T bitmapi<T>(T src, byte srcOffset, byte len,  byte dstOffset, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                Bits.bitmap(int8(src), srcOffset, len, dstOffset, ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                Bits.bitmap(int16(src),srcOffset, len, dstOffset, ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                Bits.bitmap(int32(src), srcOffset, len, dstOffset, ref int32(ref dst));
            else 
                Bits.bitmap(int64(src), srcOffset, len, dstOffset, ref int64(ref dst));

            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref T bitmapu<T>(T src, byte srcOffset, byte len,  byte dstOffset, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                Bits.bitmap(uint8(src), srcOffset, len, dstOffset, ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                Bits.bitmap(uint16(src), srcOffset, len, dstOffset, ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.bitmap(uint32(src), srcOffset, len, dstOffset, ref uint32(ref dst));
            else 
                Bits.bitmap(uint64(src), srcOffset, len, dstOffset, ref uint64(ref dst));            
            return ref dst;

        }

        [MethodImpl(Inline)]
        static ref T bitmapf<T>(T src, byte srcOffset, byte len,  byte dstOffset, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                Bits.bitmap(float32(src), srcOffset, len, dstOffset, ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                Bits.bitmap(float64(src), srcOffset, len, dstOffset, ref float64(ref dst));
            else            
                throw unsupported<T>();                        
            return ref dst;
        }
    }

}