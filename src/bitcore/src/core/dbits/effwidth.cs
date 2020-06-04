//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
        
    using static Seed;
    
    partial class Bits
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="src"></param>
        /// <Remarks>Adapted from .Net Core project System.Reflection.Metadata, BitArithmetic class</Remarks>
        [MethodImpl(Inline), Op]
        public static int bitcount(uint src)
        {
            const uint Mask01010101 = 0x55555555u;
            const uint Mask00110011 = 0x33333333u;
            const uint Mask00001111 = 0x0F0F0F0Fu;
            const uint Mask00000001 = 0x01010101u;
            const byte Offset1 = 1;
            const byte Offset2 = 2;
            const byte Offset4 = 4;
            const byte Offset = 24;

            unchecked
            {
                src = src - ((src >> Offset1) & Mask01010101);
                src = (src & Mask00110011) + ((src >> Offset2) & Mask00110011);
                var count = (int)((src + (src >> Offset4) & Mask00001111) * Mask00000001) >> Offset;
                return count;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="src"></param>
        /// <Remarks>Adapted from .Net Core project System.Reflection.Metadata, BitArithmetic class</Remarks>
        [MethodImpl(Inline), Op]
        public static int bitcount(ulong src)
        {
            const ulong Mask01010101 = 0x5555555555555555UL;
            const ulong Mask00110011 = 0x3333333333333333UL;
            const ulong Mask00001111 = 0x0F0F0F0F0F0F0F0FUL;
            const ulong Mask00000001 = 0x0101010101010101UL;
            const byte Offset1 = 1;
            const byte Offset2 = 2;
            const byte Offset4 = 4;
            const byte Offset = 56;

            src = src - ((src >> Offset1) & Mask01010101);
            src = (src & Mask00110011) + ((src >> Offset2) & Mask00110011);
            var count = (int)(unchecked(((src + (src >> Offset4)) & Mask00001111) * Mask00000001) >> Offset);
            return count;
        }

        /// <summary>
        /// Computes the minimum number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), EffWidth]
        public static int effwidth(byte src)
            => 8 - nlz(src);

        /// <summary>
        /// Computes the minimum number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), EffWidth]
        public static int effwidth(ushort src)
            => 16 - nlz(src);

        /// <summary>
        /// Computes the minimum number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), EffWidth]
        public static int effwidth(uint src)
            => 32 - nlz(src);

        /// <summary>
        /// Computes the minimum number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), EffWidth]
        public static int effwidth(ulong src)
            => 64 - nlz(src);
    }
}