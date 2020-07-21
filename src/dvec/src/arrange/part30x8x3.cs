//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static z;
    using static Konst;

    partial class dvec
    {            
        // The goal is to partition the first 30 bits of a 32-bit source into 30 bytes, each with an effective width of 3
        // So, here goes
        // The pattern repeats every 32 bits
        // Each 32-bit segment can be cut into 2 16-bit parts where both parts 
        // exhibit a common pattern of 3-bit segments: [0_111_111_1 11_111_111]
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

        [MethodImpl(Inline)]
        static Vector256<uint> vpart30x8x3Mask(uint src) 
            => z.vparts(m0, m1, m2, m3, m4,0,0,0);

        // The components are now in the following order, from lo to hi:
        // 0, 5, 1, 6, 2, 7, 3, 8, 4, 9
        // 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
        // Permuting would be cheaper but, in any case...
        [MethodImpl(Inline)]
        static Vector256<ushort> vpart30x8x3Assemble(Vector256<ushort> y)
            => vparts(w256,
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
            var m = vpart30x8x3Mask(src);
            var shifts = vparts(0, 3, 6, 9, 12, 0, 0, 0); 
            var x = vbroadcast(w256, uint32(lo | hi << 16));            
            var y = v16u(dvec.vsrlv(vand(x,m), shifts));
            var z = vpart30x8x3Assemble(y);
            return z;
        }
    }
}