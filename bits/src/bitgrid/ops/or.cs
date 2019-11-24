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

        public static BitGrid32<T> or<T>(BitGrid32<T> gx, BitGrid32<T> gy)
            where T : unmanaged
                => math.or(gx,gy);

        [MethodImpl(Inline)]
        public static BitGrid64<T> or<T>(BitGrid64<T> gx, BitGrid64<T> gy)
            where T : unmanaged
                => math.or(gx,gy);

        [MethodImpl(Inline)]
        public static BitGrid128<T> or<T>(in BitGrid128<T> gx, in BitGrid128<T> gy)
            where T : unmanaged
                => ginx.vor<T>(gx,gy);

        [MethodImpl(Inline)]
        public static BitGrid256<T> or<T>(in BitGrid256<T> gx, in BitGrid256<T> gy)
            where T : unmanaged
                => ginx.vor<T>(gx,gy);

    }
}
