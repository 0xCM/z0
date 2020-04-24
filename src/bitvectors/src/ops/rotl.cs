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
        /// Rotates source bits leftward
        /// </summary>
        /// <param name="src">The source bitvector</param>
        /// <param name="offset">The rotation magnitude</param>
        [MethodImpl(Inline), Rotl]
        public static BitVector4 rotl(BitVector4 src, byte offset)
            => gbits.rotl(src.Data, offset, src.Width);

        /// <summary>
        /// Rotates source bits leftward
        /// </summary>
        /// <param name="src">The source bitvector</param>
        /// <param name="offset">The rotation magnitude</param>
        [MethodImpl(Inline), Rotl]
        public static BitVector8 rotl(BitVector8 src, byte offset)
            => gbits.rotl(src.Data,offset);
            
        /// <summary>
        /// Rotates source bits leftward
        /// </summary>
        /// <param name="src">The source bitvector</param>
        /// <param name="offset">The rotation magnitude</param>
        [MethodImpl(Inline), Rotl]
        public static BitVector16 rotl(BitVector16 src, byte offset)
            => gbits.rotl(src.Data,offset);

        /// <summary>
        /// Rotates source bits leftward
        /// </summary>
        /// <param name="src">The source bitvector</param>
        /// <param name="offset">The rotation magnitude</param>
        [MethodImpl(Inline), Rotl]
        public static BitVector32 rotl(BitVector32 src, byte offset)
            => gbits.rotl(src.Data,offset);

        /// <summary>
        /// Rotates source bits leftward
        /// </summary>
        /// <param name="src">The source bitvector</param>
        /// <param name="offset">The rotation magnitude</param>
        [MethodImpl(Inline), Rotl]
        public static BitVector64 rotl(BitVector64 src, byte offset)
             => gbits.rotl(src.Data,offset);

        /// <summary>
        /// Rotates source bits leftward
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The rotation magnitude</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Rotl, Closures(UnsignedInts)]
        public static BitVector<T> rotl<T>(BitVector<T> x, byte offset)
            where T : unmanaged
                => gbits.rotl(x.Data,offset);

        /// <summary>
        /// Rotates source bits leftward
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The rotation magnitude</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> rotl<N,T>(BitVector<N,T> x, byte offset)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.rotl(x.Data, offset, x.Width);

        /// <summary>
        /// Rotates source bits leftward
        /// </summary>
        /// <param name="src">The source bitvector</param>
        /// <param name="offset">The rotation magnitude</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> rotl<N,T>(in BitVector128<N,T> src, byte offset)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gvec.vrotlx(src.Data, offset);
    }
}