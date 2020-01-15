//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;
    
    using static As;

    partial class gbits
    {
        /// <summary>
        /// Computes the position of the highest enabled source bit, a number in the inclusive range [0 , bitsize[T] - 1]
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), PrimalClosures(PrimalKind.UnsignedInts)]
        public static int msbpos<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Bits.msbpos(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return Bits.msbpos(uint16(src));
            else if(typeof(T) == typeof(uint))
                return Bits.msbpos(uint32(src));
            else if(typeof(T) == typeof(ulong))
                return Bits.msbpos(uint64(src));
            else            
                throw unsupported<T>();
        }           
    }
}