//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static nfunc;
    using static As;

    partial class bitvector
    {
        /// <summary>
        /// Computes the complememt bitvector ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 flip(BitVector4 src)
            => TakeHi((byte)((byte)(~src.data) << 4));

        [MethodImpl(Inline)]
        static byte TakeHi(byte src)        
            => (byte)((src >> 4) & 0xF);

        /// <summary>
        /// Computes the complememt bitvector ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 flip(BitVector8 x)
            => math.flip(x.data);
            
        /// <summary>
        /// Computes the complememt bitvector ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 flip(BitVector16 x)
            => math.flip(x.data);

        /// <summary>
        /// Computes the complememt bitvector ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 flip(BitVector32 x)
            => math.flip(x.data);

        /// <summary>
        /// Computes the complememt bitvector ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 flip(BitVector64 x)
            => math.flip(x.data);
 

    }
}