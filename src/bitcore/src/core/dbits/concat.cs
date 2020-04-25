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
        /// Concatenates the bits of 2 unsigned 8-bit integers to produce an unsigned 16-bit integer
        /// [a b] -> ab
        /// </summary>
        [MethodImpl(Inline), Concat]
        public static ushort concat(byte x0, byte x1)
            => (ushort)((ushort)x0 << 0 * 8 | (ushort)x1 << 1 * 8);

        /// <summary>
        /// Concatenates the bits of 2 unsigned 16-bit integers to produce and unsigned 32-bit integer
        /// [a b] -> ab
        /// </summary>
        [MethodImpl(Inline), Concat]
        public static uint concat(ushort x0, ushort x1)
              => (uint)x0 << 0 * 16 | (uint)x1 << 1 * 16;

        /// <summary>
        /// Concatenates the bits of 2 unsigned 32-bit integers to produce an unsigned 64-bit integer
        /// [a b] -> ab
        /// </summary>
        [MethodImpl(Inline), Concat]
        public static ulong concat(in uint x0, in uint x1)
              => (ulong)x0 | (ulong)x1 << 32;
        
        /// <summary>
        /// Concatenates the bits of 4 unsigned 8-bit integers to produce an unsigned 64-bit integer
        /// [a b c d] -> abcd
        /// </summary>
        [MethodImpl(Inline), Concat]
        public static uint concat(byte x0, byte x1, byte x2, byte x3)
            => (uint)x0 << 0 * 8 | (uint)x1 << 1 * 8 | (uint)x2 << 2 * 8 | (uint)x3 << 3 * 8;

        /// <summary>
        /// Concatenates the bits of 4 unsigned 16-bit integers to produce an unsigned 64-bit integer
        /// [a b c d] -> abcd
        /// </summary>
        [MethodImpl(Inline), Concat]
        public static ulong concat(ushort x0, ushort x1, ushort x2, ushort x3)
            => (uint)x0 << 0 * 16 | (uint)x1 << 1 * 16 | (uint)x2 << 2 * 16 | (uint)x3 << 3 * 16;

        /// <summary>
        /// Concatenates the bits of 8 unsigned 8-bit integers to produce an unsigned 64-bit integer
        /// [a b c d] -> abcd
        /// </summary>
        [MethodImpl(Inline), Concat]
        public static ulong concat(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
        {            
            return 
              (ulong)x0 << 0 * 8
            | (ulong)x1 << 1 * 8
            | (ulong)x2 << 2 * 8
            | (ulong)x3 << 3 * 8
            | (ulong)x4 << 4 * 8
            | (ulong)x5 << 5 * 8
            | (ulong)x6 << 6 * 8
            | (ulong)x7 << 7 * 8
            ;
        }        
    }
}