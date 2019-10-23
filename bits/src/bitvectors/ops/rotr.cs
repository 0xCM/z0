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
        /// Rotates the source bits rightwards
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> rotr<T>(BitVector<T> x, int offset)
            where T : unmanaged
                => gbits.rotr(x.Data,offset);

        /// <summary>
        /// Computes a rightward bit rotation
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector4 rotr(BitVector4 x, int offset)
            => Bits.rotr(x.Scalar,offset);

        /// <summary>
        /// Computes a rightward bit rotation
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector8 rotr(BitVector8 x, int offset)
            => Bits.rotr(x.Scalar,offset);
            
        /// <summary>
        /// Computes a rightward bit rotation
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector16 rotr(BitVector16 x, int offset)
            => Bits.rotr(x.Scalar,offset);

        /// <summary>
        /// Computes a rightward bit rotation
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector32 rotr(BitVector32 x, int offset)
            => Bits.rotr(x.Scalar,offset);

        /// <summary>
        /// Computes a rightward bit rotation
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector64 rotr(BitVector64 x, int offset)
             => Bits.rotr(x.Scalar,offset);
    }

}