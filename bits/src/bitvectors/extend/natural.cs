//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitVectorX
    {
     
        /// <summary>
        /// Converts the source bitvector to an equivalent natural bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<N4,byte> ToNatural(this BitVector4 src)
            => BitVector.inject(src.data,n4);

        /// <summary>
        /// Converts the source bitvector to an equivalent natural bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<N8,byte> ToNatural(this BitVector8 src)
            => BitVector.inject(src.data,n8);


        /// <summary>
        /// Converts the source bitvector to an equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<N32,uint> ToNatural(this BitVector32 src)
            => BitVector.inject(src.data,n32);



    }
}