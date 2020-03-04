//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    
    partial class Bits
    {                
        /// <summary>
        /// Reverses the bits in a byte
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <reference>https://graphics.stanford.edu/~seander/bithacks.htm</reference>
        [MethodImpl(Inline), Op]
        public static byte rev(byte src)
            => (byte)(((src * 0x80200802ul) & 0x0884422110ul) * 0x0101010101ul >> 32);

        /// <summary>
        /// Reverses the bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline), Op]
        public static ushort rev(ushort src)
            => concat(rev(hi(src)),rev(lo(src)));

        [MethodImpl(Inline), Op]
        public static uint rev(uint x)
        {
            x = (((x & 0xaaaaaaaa) >> 1) | ((x & 0x55555555) << 1));
            x = (((x & 0xcccccccc) >> 2) | ((x & 0x33333333) << 2));
            x = (((x & 0xf0f0f0f0) >> 4) | ((x & 0x0f0f0f0f) << 4));
            x = (((x & 0xff00ff00) >> 8) | ((x & 0x00ff00ff) << 8));
            return((x >> 16) | (x << 16));
        }

        /// <summary>
        /// Reverses the bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline), Op]
        public static ulong rev(ulong src)
            => concat(rev(hi(src)),rev(lo(src)));
    }
}