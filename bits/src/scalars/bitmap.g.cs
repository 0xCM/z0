//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
            if(typeof(T) == typeof(byte))
                Bits.bitmap(uint8(src), srcOffset, len, dstOffset, ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                Bits.bitmap(uint16(src), srcOffset, len, dstOffset, ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.bitmap(uint32(src), srcOffset, len, dstOffset, ref uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                Bits.bitmap(uint64(src), srcOffset, len, dstOffset, ref uint64(ref dst));            
            else
                throw unsupported<T>();
            return ref dst;            
        }
    }
}