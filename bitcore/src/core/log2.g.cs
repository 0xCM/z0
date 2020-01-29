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
    using static AsIn;

    partial class gbits
    {        
        /// <summary>
        /// Computes floor(log(src,2))
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static uint log2<T>(in T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return Bits.log2(uint8(src));
            else if(typeof(T) == typeof(ushort))
                 return Bits.log2(uint16(src));
            else if(typeof(T) == typeof(uint))
                 return Bits.log2(uint32(src));
            else if(typeof(T) == typeof(ulong))
                 return Bits.log2(uint64(src));
            else 
                throw unsupported<T>();
        }
    }
}