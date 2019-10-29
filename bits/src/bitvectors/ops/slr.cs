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
        /// Applies a logical right shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector<T> srl<T>(BitVector<T> x, int offset)
            where T : unmanaged
                => gmath.srl(x.Data,offset);

        /// <summary>
        /// Applies a logical right shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector4 srl(BitVector4 x, int offset)
            => math.srl(x.data,offset);

        /// <summary>
        /// Applies a logical right shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector8 srl(BitVector8 x, int offset)
            => math.srl(x.data,offset);
            
        /// <summary>
        /// Applies a logical right shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector16 srl(BitVector16 x, int offset)
            => math.srl(x.data,offset);

        /// <summary>
        /// Applies a logical right shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector32 srl(BitVector32 x, int offset)
            => math.srl(x.data, offset);

        /// <summary>
        /// Applies a logical right shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector64 srl(BitVector64 x, int offset)
            => math.srl(x.data,offset);
 

    }

}