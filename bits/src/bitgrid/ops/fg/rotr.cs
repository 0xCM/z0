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
        public static BitGrid16<T> rotr<T>(BitGrid16<T> gx, int shift)
            where T : unmanaged
        {
            var dst = zeros<T>(n16);
            gcells.rotr(in gx.Head, shift, ref dst.Head, gx.CellCount);
            return dst;
        }

        [MethodImpl(Inline)]
        public static BitGrid32<T> rotr<T>(BitGrid32<T> gx, int shift)
            where T : unmanaged
        {
            var dst = zeros<T>(n32);
            gcells.rotr(in gx.Head, shift, ref dst.Head, gx.CellCount);
            return dst;
        }

        [MethodImpl(Inline)]
        public static BitGrid64<T> rotr<T>(BitGrid64<T> gx, int shift)
            where T : unmanaged
        {
            var dst = zeros<T>(n64);
            gcells.rotr(in gx.Head, shift, ref dst.Head, gx.CellCount);
            return dst;
        }

        [MethodImpl(Inline)]
        public static BitGrid128<T> rotr<T>(in BitGrid128<T> gx, int shift)
            where T : unmanaged
                => ginx.vrotr<T>(gx,(byte)shift);

        [MethodImpl(Inline)]
        public static BitGrid256<T> rotr<T>(in BitGrid256<T> gx, int shift)
            where T : unmanaged
                => ginx.vrotr<T>(gx,(byte)shift);
    }

}