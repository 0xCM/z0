//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vpart30x8x3(uint src)
        {
            var a = src & uint.MaxValue >> 2;
            var lo = uint16(BitMasks.Lsb16x16x15 & a);
            var hi = uint16(BitMasks.Lsb16x16x15 & (a >> 15));
            
            var x = CpuVector.vbroadcast(n256,uint32(lo | hi << 16));
            
            // The pattern repeats every 32 bits
            // Each 32-bit segment can be cut into 2 16-bit parts where both parts 
            // exhibits a common pattern of 3-bit segments: [0_111_111_1 11_111_111]
            // 0 | [0_111_111_1 11_111_111 0_111_111_1 11_111_111] -> [0_000_000_0 00_000_111 0_000_000_0 00_000_111] {0,5}
            // 1 | [0_111_111_1 11_111_111 0_111_111_1 11_111_111] -> [0_000_000_0 00_111_000 0_000_000_0 00_111_000] {1,6} -->(3) [000___111 | 000___111]
            // 2 | [0_111_111_1 11_111_111 0_111_111_1 11_111_111] -> [0_000_000_1 11_000_000 0_000_000_1 11_000_000] {2,7} -->(6) [...]
            // 3 | [0_111_111_1 11_111_111 0_111_111_1 11_111_111] -> [0_000_111_0 00_000_000 0_000_111_0 00_000_000] {3,8} -->(9)
            // 4 | [0_111_111_1 11_111_111 0_111_111_1 11_111_111] -> [0_111_000_0 00_000_000 0_111_000_0 00_000_000] {4,9} -->(12)

            const uint m0 = BitMasks.Lsb32x16x3;
            const uint m1 = BitMasks.Lsb32x16x3 << 3;
            const uint m2 = BitMasks.Lsb32x16x3 << 6;
            const uint m3 = BitMasks.Lsb32x16x3 << 9;
            const uint m4 = BitMasks.Lsb32x16x3 << 12;
            var m = Vectors.vparts(n256, m0,m1,m2,m3,m4,0,0,0);
            var shifts =Vectors.vparts(n256,0, 3, 6, 9, 12,0,0,0); 

            var y = v16u(dinx.vsrlv(dinx.vand(x,m), shifts));

            // The components are now in the following order, from lo to hi:
            // 0, 5, 1, 6, 2, 7, 3, 8, 4, 9
            // 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            // So, they need to be permuted; fake it for now
            var z = Vectors.vparts(n256, 
                vcell(y,0), // 0
                vcell(y,2), // 1
                vcell(y,4), // 2
                vcell(y,6), // 3
                vcell(y,8), // 4
                vcell(y,1), // 5
                vcell(y,3), // 6
                vcell(y,5), // 7
                vcell(y,7), // 8
                vcell(y,9), // 9
                0,0,0,0,0,0);

            return z;

        }

        [MethodImpl(Inline), Op]
        public static Vector256<byte> vpart32x8x1(uint src)
        {
            var x = CpuVector.vbroadcast(n256, src);
            var y = CpuVector.vbroadcast(n256,BitMasks.Msb32x8x7);
            return v8u(dinx.vand(x,y));
        }

    }
}