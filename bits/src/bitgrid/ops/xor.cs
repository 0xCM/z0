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
        public static BitGrid32<T> xor<T>(BitGrid32<T> gx, BitGrid32<T> gy)
            where T : unmanaged
                => math.xor(gx,gy);

        [MethodImpl(Inline)]
        public static BitGrid64<T> xor<T>(BitGrid64<T> gx, BitGrid64<T> gy)
            where T : unmanaged
                => math.xor(gx,gy);

        [MethodImpl(Inline)]
        public static BitGrid128<T> xor<T>(in BitGrid128<T> gx, in BitGrid128<T> gy)
            where T : unmanaged
                => ginx.vxor<T>(gx,gy);

        [MethodImpl(Inline)]
        public static BitGrid256<T> xor<T>(in BitGrid256<T> gx, in BitGrid256<T> gy)
            where T : unmanaged
                => ginx.vxor<T>(gx,gy);

    }
}
