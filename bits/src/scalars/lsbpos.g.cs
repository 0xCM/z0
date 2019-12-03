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
        /// Returns the position of the least on bit in the source
        /// </summary>
        /// <param name="src">The source vale</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static int lsbpos<T>(T src)
            where T : unmanaged
                => ntz(src);
        // {
        //     if(typeof(T) == typeof(byte))
        //         return Bits.lsbpos(uint8(src));
        //     else if(typeof(T) == typeof(ushort))
        //         return Bits.lsbpos(uint16(src));
        //     else if(typeof(T) == typeof(uint))
        //         return Bits.lsbpos(uint32(src));
        //     else if(typeof(T) == typeof(ulong))
        //         return Bits.lsbpos(uint64(src));
        //     else            
        //         throw unsupported<T>();
        // }           
    }
}