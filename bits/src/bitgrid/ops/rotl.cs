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
        [MethodImpl(Inline)]
        public static BitGrid16<T> rotl<T>(BitGrid16<T> gx, int shift)
            where T : unmanaged
        {
            var dst = zeros<T>(n16);
            gcells.rotl(in gx.Head, shift, ref dst.Head, gx.CellCount);
            return dst;
        }


        [MethodImpl(Inline)]
        public static BitGrid32<T> rotl<T>(BitGrid32<T> gx, int shift)
            where T : unmanaged
        {
            var dst = zeros<T>(n32);
            gcells.rotl(in gx.Head, shift, ref dst.Head, gx.CellCount);
            return dst;
        }

        [MethodImpl(Inline)]
        public static BitGrid64<T> rotl<T>(BitGrid64<T> gx, int shift)
            where T : unmanaged
        {
            var dst = zeros<T>(n64);
            gcells.rotl(in gx.Head, shift, ref dst.Head, gx.CellCount);
            return dst;
        }

        [MethodImpl(Inline)]
        public static BitGrid128<T> rotl<T>(in BitGrid128<T> gx, int shift)
            where T : unmanaged
                => ginx.vrotl<T>(gx,(byte)shift);

        [MethodImpl(Inline)]
        public static BitGrid256<T> rotl<T>(in BitGrid256<T> gx, int shift)
            where T : unmanaged
                => ginx.vrotl<T>(gx,(byte)shift);
 
        [MethodImpl(Inline)]
        public static BitGrid64<T> rotl<M,N,T>(BitGrid64<M,N,T> gx, int shift)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var gz = new BitGrid64<T>(0ul);
            gcells.rotl(in gx.Head, shift, ref gz.Head, gx.CellCount);
            return gz;
        }


    }
}