//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Memories;

    partial class BitGrid
    {
        [MethodImpl(Inline)]
        public static BitGrid128<M,N,uint> sllv<M,N>(in BitGrid128<M,N,uint> g, Vector128<uint> offsets)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => dvec.vsllv(g.Data, offsets);

        [MethodImpl(Inline)]
        public static BitGrid128<M,N,ulong> sllv<M,N>(in BitGrid128<M,N,ulong> g, Vector128<ulong> offsets)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => dvec.vsllv(g.Data, offsets);

        [MethodImpl(Inline)]
        public static BitGrid256<M,N,uint> sllv<M,N>(in BitGrid256<M,N,uint> g, Vector256<uint> offsets)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => dvec.vsllv(g.Data, offsets);

        [MethodImpl(Inline)]
        public static BitGrid256<M,N,ulong> sllv<M,N>(in BitGrid256<M,N,ulong> g, Vector256<ulong> offsets)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => dvec.vsllv(g.Data, offsets);
    }
}