//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Core;    
    using static As;

    partial class gbits
    {
        /// <summary>
        /// Extracts the lower source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static T lo<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.lo(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.lo(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.lo(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.lo(uint64(src)));
            else            
                throw Unsupported.define<T>();
        }           
    }
}