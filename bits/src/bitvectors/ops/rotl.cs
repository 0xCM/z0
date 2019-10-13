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
        /// Computes a leftward bit rotation
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector4 rotl(BitVector4 x, int offset)
            => Bits.rotl(x.Scalar,offset);

        /// <summary>
        /// Computes a leftward bit rotation
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector8 rotl(BitVector8 x, int offset)
            => Bits.rotl(x.Scalar,offset);
            
        /// <summary>
        /// Computes a leftward bit rotation
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector16 rotl(BitVector16 x, int offset)
            => Bits.rotl(x.Scalar,offset);

        /// <summary>
        /// Computes a leftward bit rotation
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector32 rotl(BitVector32 x, int offset)
            => Bits.rotl(x.Scalar,offset);

        /// <summary>
        /// Computes a leftward bit rotation
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector64 rotl(BitVector64 x, int offset)
             => Bits.rotl(x.Scalar,offset);


    }

}