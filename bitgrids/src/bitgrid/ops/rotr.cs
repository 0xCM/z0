//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        [MethodImpl(Inline)]
        public static BitGrid16<T> rotr<T>(BitGrid16<T> g, int shift)
            where T : unmanaged
                => init16<T>(g.RowCount, g.ColCount, Bits.rotr(g, shift));

        [MethodImpl(Inline)]
        public static BitGrid32<T> rotr<T>(BitGrid32<T> g, int shift)
            where T : unmanaged
                => init32<T>(g.RowCount, g.ColCount, Bits.rotr(g, shift));
        
        [MethodImpl(Inline)]
        public static BitGrid64<T> rotr<T>(BitGrid64<T> g, int shift)
            where T : unmanaged
                => init64<T>(g.RowCount, g.ColCount, Bits.rotr(g, shift));

        [MethodImpl(Inline)]
        public static BitGrid16<M,N,T> rotr<M,N,T>(BitGrid16<M,N,T> g, int shift)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => Bits.rotr(g.Data,shift);

        [MethodImpl(Inline)]
        public static BitGrid32<M,N,T> rotr<M,N,T>(BitGrid32<M,N,T> g, int shift)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => Bits.rotr(g.Data,shift);

        [MethodImpl(Inline)]
        public static BitGrid64<M,N,T> rotr<M,N,T>(BitGrid64<M,N,T> g, int shift)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => Bits.rotr(g.Data,shift);

        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> rotr<M,N,T>(in BitGrid128<M,N,T> g, int shift)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => ginx.vrotr<T>(g,(byte)shift);

        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> rotr<M,N,T>(in BitGrid256<M,N,T> g, int shift)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => ginx.vrotr<T>(g,(byte)shift);
    }
}