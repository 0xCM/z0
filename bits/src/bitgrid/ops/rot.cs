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
        public static BitGrid32<T> rotl<T>(BitGrid32<T> gx, int shift)
            where T : unmanaged
        {
            var gz = new BitGrid32<T>(0u);
            gcells.rotl(in gx.Head, shift, ref gz.Head, gx.Count);
            return gz;
        }

        [MethodImpl(Inline)]
        public static BitGrid32<T> rotr<T>(BitGrid32<T> gx, int shift)
            where T : unmanaged
        {
            var gz = new BitGrid32<T>(0u);
            gcells.rotr(in gx.Head, shift, ref gz.Head, gx.Count);
            return gz;
        }

        [MethodImpl(Inline)]
        public static BitGrid64<T> rotl<T>(BitGrid64<T> gx, int shift)
            where T : unmanaged
        {
            var gz = new BitGrid64<T>(0ul);
            gcells.rotl(in gx.Head, shift, ref gz.Head, gx.Count);
            return gz;
        }

        [MethodImpl(Inline)]
        public static BitGrid64<T> rotr<T>(BitGrid64<T> gx, int shift)
            where T : unmanaged
        {
            var gz = new BitGrid64<T>(0ul);
            gcells.rotr(in gx.Head, shift, ref gz.Head, gx.Count);
            return gz;
        }

        [MethodImpl(Inline)]
        public static BitGrid128<T> rotl<T>(in BitGrid128<T> gx, int shift)
            where T : unmanaged
                => ginx.vrotl<T>(gx,(byte)shift);

        [MethodImpl(Inline)]
        public static BitGrid128<T> rotr<T>(in BitGrid128<T> gx, int shift)
            where T : unmanaged
                => ginx.vrotr<T>(gx,(byte)shift);

        [MethodImpl(Inline)]
        public static BitGrid256<T> rotl<T>(in BitGrid256<T> gx, int shift)
            where T : unmanaged
                => ginx.vrotl<T>(gx,(byte)shift);

        [MethodImpl(Inline)]
        public static BitGrid256<T> rotr<T>(in BitGrid256<T> gx, int shift)
            where T : unmanaged
                => ginx.vrotr<T>(gx,(byte)shift);

    }
}
