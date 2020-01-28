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
        /// Computes the minimal number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.UnsignedInts)]
        public static int effwidth<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Bits.width(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return Bits.width(uint16(src));
            else if(typeof(T) == typeof(uint))
                return Bits.width(uint32(src));
            else if(typeof(T) == typeof(ulong))
                return Bits.width(uint64(src));
            else            
                throw unsupported<T>();
        }           
    }
}