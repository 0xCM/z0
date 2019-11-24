//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;    

    partial class BitVector
    {

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector<T> generic<T>(BitString src)
            where T : unmanaged
                => src.TakeScalar<T>();

        /// <summary>
        /// Allocates and fills a byte-secialized generic bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector<byte> generic(N8 n8, byte init)
            => init;

        /// <summary>
        /// Allocates and fills a byte-secialized generic bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector<byte> generic(N8 n, bit b0, bit b1, bit b2, bit b3)
            => from(n, b0, b1, b2, b3);

        /// <summary>
        /// Creates a generic bitvector from 4 explicit bytes
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector<uint> generic(byte x0, byte x1, byte x2, byte x3)
            => BitVector<uint>.From(Bits.pack(x0,x1,x2,x3));

    }

}