//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;

    partial class BitGrid
    {
        /// <summary>
        /// Circulates grid content clockwise
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="shift">The rotation amount</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<T> rotl<T>(BitGrid16<T> g, int shift)
            where T : unmanaged
                => init16<T>(g.RowCount, g.ColCount, Bits.rotl(g, shift));

        /// <summary>
        /// Circulates grid content clockwise
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="shift">The rotation amount</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<T> rotl<T>(BitGrid32<T> g, int shift)
            where T : unmanaged
                => init32<T>(g.RowCount, g.ColCount, Bits.rotl(g, shift));

        /// <summary>
        /// Circulates grid content clockwise
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="shift">The rotation amount</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<T> rotl<T>(BitGrid64<T> g, int shift)
            where T : unmanaged
                => init64<T>(g.RowCount, g.ColCount, Bits.rotl(g, shift));

        [MethodImpl(Inline)]
        public static BitGrid16<M,N,T> rotl<M,N,T>(BitGrid16<M,N,T> g, int shift)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => Bits.rotl(g.Data,shift);

        [MethodImpl(Inline)]
        public static BitGrid32<M,N,T> rotl<M,N,T>(BitGrid32<M,N,T> g, int shift)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => Bits.rotl(g.Data,shift);

        [MethodImpl(Inline)]
        public static BitGrid64<M,N,T> rotl<M,N,T>(BitGrid64<M,N,T> g, int shift)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => Bits.rotl(g.Data,shift);

        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> rotl<M,N,T>(in BitGrid128<M,N,T> g, int shift)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => gvec.vrotl<T>(g,(byte)shift);

        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> rotl<M,N,T>(in BitGrid256<M,N,T> g, int shift)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => gvec.vrotl<T>(g,(byte)shift);
    }
}