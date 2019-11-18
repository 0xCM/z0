//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    
    using static HexConst;

    partial class BitVector
    {
        /// <summary>
        /// Creates a bitvector with uniformly alternating states where the state of the
        /// first bit is determine by a specified parity bit
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="parity">The state of the first bit</param>
        [MethodImpl(Inline)]
        public static BitVector<T> alt<T>(bit parity)
            where T : unmanaged
                => parity ? convert<T>(x5555555555555555) : convert<T>(xAAAAAAAAAAAAAAAA);        

        /// <summary>
        /// Creates a bitvector with uniformly alternating states where the state of the
        /// first bit is determine by a specified parity bit
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="parity">The state of the first bit</param>
        [MethodImpl(Inline)]
        public static BitVector8 alt(N8 n, bit parity)
            => parity ? x55 : AA;        

        /// <summary>
        /// Creates a bitvector with uniformly alternating states where the state of the
        /// first bit is determine by a specified parity bit
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="parity">The state of the first bit</param>
        [MethodImpl(Inline)]
        public static BitVector16 alt(N16 n, bit parity)
            => parity ? x5555 : xAAAA;        

        /// <summary>
        /// Creates a bitvector with uniformly alternating states where the state of the
        /// first bit is determine by a specified parity bit
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="parity">The state of the first bit</param>
        [MethodImpl(Inline)]
        public static BitVector32 alt(N32 n, bit parity)
            => parity ? x55555555 : xAAAAAAAA;        

        /// <summary>
        /// Creates a bitvector with uniformly alternating states where the state of the
        /// first bit is determine by a specified parity bit
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="parity">The state of the first bit</param>
        [MethodImpl(Inline)]
        public static BitVector64 alt(N64 n, bit parity)
            => parity ? x5555555555555555 : xAAAAAAAAAAAAAAAA;
    }
}