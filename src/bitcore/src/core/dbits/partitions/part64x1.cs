//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;
    using static As;
       
    partial class Bits
    {
        /// <summary>
        /// Partitions a 64-bit source into 64 8-bit targets, each of effective width 1
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline), Op]
        public static ref byte part64x1(ulong src, ref byte dst)
        {
            ref var target = ref seek64(dst,0);
            seek(target, 0) = lsb8x1(src);
            seek(target, 1) = lsb8x1(src >> 8);
            seek(target, 2) = lsb8x1(src >> 16);
            seek(target, 3) = lsb8x1(src >> 24);
            seek(target, 4) = lsb8x1(src >> 32);
            seek(target, 5) = lsb8x1(src >> 40);
            seek(target, 6) = lsb8x1(src >> 48);
            seek(target, 7) = lsb8x1(src >> 56);
            return ref dst;
        }
 
        /// <summary>
        /// Partitions a 64-bit source value into 64 individual bit values
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline), Op]
        public static void part64x1(ulong src, Span<bit> dst)
        {
            // each bit has a 32-bit physical width so 2 bit values = 64 bits of storage
            // thus, the target covers 32 64-bit segments where each segment covers 2 bit values            
            ref var target = ref first(dst.Cast<bit,ulong>());
            for(byte i=0; i<32; i++)
                seek(target, i) = lsb32x1(src >> i);
        }
    }
}