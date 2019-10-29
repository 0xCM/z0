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
        /// Applies a logical left shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector<T> sll<T>(BitVector<T> x, int offset)
            where T : unmanaged
                => gmath.srl(x.Data,offset);

        /// <summary>
        /// Applies a logical left shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector4 sll(BitVector4 x, int offset)
            => math.sll(x.Scalar,offset);

        /// <summary>
        /// Applies a logical left shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector8 sll(BitVector8 x, int offset)
            => math.sll(x.Scalar,offset);
            
        /// <summary>
        /// Applies a logical left shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector16 sll(BitVector16 x, int offset)
            => math.sll(x.Scalar,offset);

        /// <summary>
        /// Applies a logical left shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector32 sll(BitVector32 x, int offset)
            => math.sll(x.Scalar,offset);

        /// <summary>
        /// Applies a logical left shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector64 sll(BitVector64 x, int offset)
            => math.sll(x.Scalar,offset);
 

    }

}