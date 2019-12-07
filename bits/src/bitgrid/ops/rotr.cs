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

    partial class BitGrid
    {

        /// <summary>
        /// Rotates the linearized grid bits rightward
        /// </summary>
        /// <param name="gx">The source grid</param>
        /// <param name="shift">The number of bits to rotate</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<T> rotr<T>(BitGrid32<T> gx, int shift)
            where T : unmanaged
                => bg32<T>(gx.RowCount, gx.ColCount, Bits.rotr(gx, shift));
        
        [MethodImpl(Inline)]
        public static BitGrid64<T> rotr<T>(BitGrid64<T> gx, int shift)
            where T : unmanaged
                => Bits.rotr(gx.Data,shift);

        [MethodImpl(Inline)]
        public static BitGrid16<M,N,T> rotr<M,N,T>(BitGrid16<M,N,T> gx, int shift)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => Bits.rotr(gx.Data,shift);

        [MethodImpl(Inline)]
        public static BitGrid32<M,N,T> rotr<M,N,T>(BitGrid32<M,N,T> gx, int shift)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => Bits.rotr(gx.Data,shift);

        [MethodImpl(Inline)]
        public static BitGrid64<M,N,T> rotr<M,N,T>(BitGrid64<M,N,T> gx, int shift)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => Bits.rotr(gx.Data,shift);

        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> rotr<M,N,T>(in BitGrid128<M,N,T> gx, int shift)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => ginx.vrotr<T>(gx,(byte)shift);

        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> rotr<M,N,T>(in BitGrid256<M,N,T> gx, int shift)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => ginx.vrotr<T>(gx,(byte)shift);
    }
}