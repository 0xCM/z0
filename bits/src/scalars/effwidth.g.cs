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
        /// Creates a bitview over a source value
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitView<T> view<T>(ref T src)
            where T: unmanaged
                => new BitView<T>(ref src);

        /// <summary>
        /// Computes the minimal number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static int effwidth<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Bits.effwidth(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return Bits.effwidth(uint16(src));
            else if(typeof(T) == typeof(uint))
                return Bits.effwidth(uint32(src));
            else if(typeof(T) == typeof(ulong))
                return Bits.effwidth(uint64(src));
            else            
                throw unsupported<T>();
        }           
    }
}