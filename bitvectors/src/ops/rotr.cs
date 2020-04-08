//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    partial class BitVector
    {
        /// <summary>
        /// Computes a rightward bit rotation
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The rotation magnitude</param>
        [MethodImpl(Inline), Rotr]
        public static BitVector4 rotr(BitVector4 x, byte offset)
            => gbits.rotr(x.data,offset, x.Width);

        /// <summary>
        /// Computes a rightward bit rotation
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The rotation magnitude</param>
        [MethodImpl(Inline), Rotr]
        public static BitVector8 rotr(BitVector8 x, byte offset)
            => gbits.rotr(x.data,offset);
            
        /// <summary>
        /// Rotates source bits rightward
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The rotation magnitude</param>
        [MethodImpl(Inline), Rotr]
        public static BitVector16 rotr(BitVector16 x, byte offset)
            => gbits.rotr(x.data,offset);

        /// <summary>
        /// Computes a rightward bit rotation
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The rotation magnitude</param>
        [MethodImpl(Inline), Rotr]
        public static BitVector32 rotr(BitVector32 x, byte offset)
            => gbits.rotr(x.data,offset);

        /// <summary>
        /// Rotates source bits rightward
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The rotation magnitude</param>
        [MethodImpl(Inline), Rotr]
        public static BitVector64 rotr(BitVector64 x, byte offset)
             => gbits.rotr(x.data,offset);

        /// <summary>
        /// Rotates source bits rightward
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The rotation magnitude</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Rotr, Closures(UnsignedInts)]
        public static BitVector<T> rotr<T>(BitVector<T> x, byte offset)
            where T : unmanaged
                => gbits.rotr(x.Scalar,offset);
    }
}