//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static As;

    partial class dinx
    {            

        /// <summary>
        /// Partitions the first 30 bits of a 32-bit source into 30 bytes, each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vpart30x8x3(uint src)
        {
            var a = src >> 2;
            var lo = uint16(BitMasks.Lsb16x16x15 & uint16(a));
            var hi = uint16(a >> 15);
            
            return vbroadcast(n256,lo,hi);

            // 0 [111_111_11 1_111_111_1 11_111_111 111_111_00]        
            // 1 [111_111_11 1_111_111_1 11_111_111 111_111_00]
            // 2 [111_111_11 1_111_111_1 11_111_111 111_111_00]
            // 3 [111_111_11 1_111_111_1 11_111_111 111_111_00]
            // 4 [111_111_11 1_111_111_1 11_111_111 111_111_00]
            // 5 [111_111_11 1_111_111_1 11_111_111 111_111_00]
            // 6 [111_111_11 1_111_111_1 11_111_111 111_111_00]
            // 7 [111_111_11 1_111_111_1 11_111_111 111_111_00]

        }

        [MethodImpl(Inline)]
        public static Vector256<byte> vpart32x8x1(uint src)
        {
            var x = dinx.vbroadcast(n256, src);
            var y = dinx.vbroadcast(n256,BitMasks.Msb32x8x7);
            return v8u(dinx.vand(x,y));
        }

    }
}