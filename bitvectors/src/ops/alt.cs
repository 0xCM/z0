//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;    

    partial class BitVector
    {
        /// <summary>
        /// Creates a bitvector with uniformly alternating states where the state of 
        /// the first bit is determine by a parity bit
        /// </summary>
        /// <param name="parity">The state of the first bit</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> alt<T>(bit parity)
            where T : unmanaged
                => parity ? convert<T>(BitMasks.Even64) : convert<T>(BitMasks.Odd64);        

        /// <summary>
        /// Creates a bitvector with uniformly alternating states where the state of the
        /// first bit is determine by a specified parity bit
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="parity">The state of the first bit</param>
        [MethodImpl(Inline), Op]
        public static BitVector8 alt(N8 n, bit parity)
            => parity ? BitMasks.Even8 : BitMasks.Odd8;        

        /// <summary>
        /// Creates a bitvector with uniformly alternating states where the state of the
        /// first bit is determine by a specified parity bit
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="parity">The state of the first bit</param>
        [MethodImpl(Inline), Op]
        public static BitVector16 alt(N16 n, bit parity)
            => parity ? BitMasks.Even16 : BitMasks.Odd16;        

        /// <summary>
        /// Creates a bitvector with uniformly alternating states where the state of the
        /// first bit is determine by a specified parity bit
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="parity">The state of the first bit</param>
        [MethodImpl(Inline), Op]
        public static BitVector32 alt(N32 n, bit parity)
            => parity ? BitMasks.Even32 : BitMasks.Odd32;        

        /// <summary>
        /// Creates a bitvector with uniformly alternating states where the state of the
        /// first bit is determine by a specified parity bit
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="parity">The state of the first bit</param>
        [MethodImpl(Inline), Op]
        public static BitVector64 alt(N64 n, bit parity)
            => parity ? BitMasks.Even64 : BitMasks.Odd64;
    }
}