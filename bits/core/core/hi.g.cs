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
        /// Extracts the upper source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static T hi<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.hi(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.hi(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.hi(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.hi(uint64(src)));
            else            
                throw Unsupported.define<T>();
        }           
    }
}