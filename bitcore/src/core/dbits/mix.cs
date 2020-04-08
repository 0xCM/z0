//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// Blends alternating even operand bits 
        /// </summary>
        /// <param name="parity">The parity selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static byte mix(N0 parity, byte x, byte y)
        {
            var mask = BitMasks.Even8;
            var xE = project(select(x, mask), BitMasks.Even8);
            var yE = project(select(y, mask), BitMasks.Odd8);
            var xEy = xE | yE;
            return (byte)xEy;
        }

        /// <summary>
        /// Blends alternating odd operand bits 
        /// </summary>
        /// <param name="parity">The parity selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static byte mix(N1 parity, byte x, byte y)
        {
            var mask = BitMasks.Odd8;
            var xO = project(select(x, mask), BitMasks.Even8);
            var yO = project(select(y, mask), BitMasks.Odd8);
            var xOy = xO | yO;
            return (byte)xOy;
        }

        /// <summary>
        /// Blends alternating even operand bits 
        /// </summary>
        /// <param name="parity">The parity selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static ushort mix(N0 parity, ushort x, ushort y)
        {
            var mask = BitMasks.Even16;
            var xE = Bits.project(select(x, mask), BitMasks.Even16);
            var yE = Bits.project(select(y, mask), BitMasks.Odd16);
            var xEy = xE | yE;
            return (ushort)xEy;
        }

        /// <summary>
        /// Blends alternating odd operand bits 
        /// </summary>
        /// <param name="parity">The parity selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static ushort mix(N1 parity, ushort x, ushort y)
        {
            var mask = BitMasks.Odd16;
            var xO = Bits.project(select(x, mask), BitMasks.Even16);
            var yO = Bits.project(select(y, mask), BitMasks.Odd16);
            var xOy = xO | yO;
            return (ushort)xOy;
        }

        /// <summary>
        /// Blends alternating even operand bits 
        /// </summary>
        /// <param name="parity">The parity selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static uint mix(N0 parity, uint x, uint y)
        {
            var mask = BitMasks.Even32;
            var xE = Bits.project(select(x,mask),  BitMasks.Even32);
            var yE = Bits.project(select(y,mask),  BitMasks.Odd32);
            var xEy = xE | yE;
            return xEy;
        }

        /// <summary>
        /// Blends alternating odd operand bits 
        /// </summary>
        /// <param name="parity">The parity selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static uint mix(N1 parity, uint x, uint y)
        {
            var mask =  BitMasks.Odd32;
            var xO = Bits.project(select(x, mask),  BitMasks.Even32);
            var yO = Bits.project(select(y, mask),  BitMasks.Odd32);
            var xOy = xO | yO;
            return xOy;
        }

        /// <summary>
        /// Blends alternating even operand bits 
        /// </summary>
        /// <param name="parity">The parity selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static ulong mix(N0 parity, ulong x, ulong y)
        {
            var mask = BitMasks.Even64;
            var xE = Bits.project(select(x,mask), BitMasks.Even64);
            var yE = Bits.project(select(y,mask), BitMasks.Odd64);
            var xEy = xE | yE;
            return xEy;
        }

        /// <summary>
        /// Blends alternating odd operand bits 
        /// </summary>
        /// <param name="parity">The parity selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static ulong mix(N1 parity, ulong x, ulong y)
        {
            var mask = BitMasks.Odd64;
            var xO = Bits.project(select(x, mask), BitMasks.Even64);
            var yO = Bits.project(select(y, mask), BitMasks.Odd64);
            var xOy = xO | yO;
            return xOy;
        }
    }
}