//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    partial class BitGrid
    {
        [MethodImpl(Inline), Rotr, Closures(Numeric8x16u)]
        public static BitGrid16<T> rotr<T>(BitGrid16<T> g, byte offset)
            where T : unmanaged
                => init16<T>(Bits.rotr(g, offset));

        [MethodImpl(Inline), Rotr, Closures(Numeric8x16x32u)]
        public static BitGrid32<T> rotr<T>(BitGrid32<T> g, byte offset)
            where T : unmanaged
                => init32<T>(Bits.rotr(g, offset));
        
        [MethodImpl(Inline), Rotr, Closures(UnsignedInts)]
        public static BitGrid64<T> rotr<T>(BitGrid64<T> g, byte offset)
            where T : unmanaged
                => init64<T>(Bits.rotr(g, offset));

        [MethodImpl(Inline)]
        public static BitGrid16<M,N,T> rotr<M,N,T>(BitGrid16<M,N,T> g, byte offset)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => Bits.rotr(g.Content,offset);

        [MethodImpl(Inline)]
        public static BitGrid32<M,N,T> rotr<M,N,T>(BitGrid32<M,N,T> g, byte offset)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => Bits.rotr(g.Content,offset);

        [MethodImpl(Inline)]
        public static BitGrid64<M,N,T> rotr<M,N,T>(BitGrid64<M,N,T> g, byte offset)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => Bits.rotr(g.Content,offset);

        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> rotr<M,N,T>(in BitGrid128<M,N,T> g, byte offset)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => gvec.vrotr<T>(g,(byte)offset);

        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> rotr<M,N,T>(in BitGrid256<M,N,T> g, byte offset)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => gvec.vrotr<T>(g,(byte)offset);
    }
}