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
        /// Rotates source bits rightward
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="s">The rotation magnitude</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> rotr<T>(BitVector<T> x, int s)
            where T : unmanaged
                => gbits.rotr(x.Scalar,s);

        /// <summary>
        /// Rotates source bits rightward
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="s">The rotation magnitude</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> rotr<N,T>(BitVector<N,T> x, int s)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.rotr(x.Scalar, s, x.Width);

        /// <summary>
        /// Computes a rightward bit rotation
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector4 rotr(BitVector4 x, int s)
            => gbits.rotr(x.data,s, x.Width);

        /// <summary>
        /// Computes a rightward bit rotation
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector8 rotr(BitVector8 x, int s)
            => gbits.rotr(x.data,s);
            
        /// <summary>
        /// Rotates source bits rightward
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="s">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector16 rotr(BitVector16 x, int s)
            => gbits.rotr(x.data,s);

        /// <summary>
        /// Computes a rightward bit rotation
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector32 rotr(BitVector32 x, int s)
            => gbits.rotr(x.data,s);

        /// <summary>
        /// Rotates source bits rightward
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="s">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector64 rotr(BitVector64 x, int s)
             => gbits.rotr(x.data,s);

        /// <summary>
        /// Rotates source bits rightward
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="s">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector128 rotr(in BitVector128 x, int s)
        {
            var z = BitVector.alloc(n128);
            vblock.rotrx(n128, in x.x0, (byte)s, ref z.x0);
            return z;
        }
    }
}