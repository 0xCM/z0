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

    partial class BitVector
    {
        /// <summary>
        /// Computes the bitwise complement of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> not<T>(BitVector<T> x)
            where T : unmanaged
                => gmath.not(x.Data);

        /// <summary>
        /// Computes the complememt bitvector ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 not(BitVector4 src)
            => TakeHi((byte)((byte)(~src.data) << 4));

        /// <summary>
        /// Computes the bitwise complement ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 not(BitVector8 x)
            => math.not(x.data);
            
        /// <summary>
        /// Computes the bitwise complement ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 not(BitVector16 x)
            => math.not(x.data);

        /// <summary>
        /// Computes the bitwise complement ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 not(BitVector32 x)
            => math.not(x.data);

        /// <summary>
        /// Computes the bitwise complement ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 not(BitVector64 x)
            => math.not(x.data);
 
        [MethodImpl(Inline)]
        static byte TakeHi(byte src)        
            => (byte)((src >> 4) & 0xF);

    }
}