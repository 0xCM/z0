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
        public static BitGrid32<T> not<T>(BitGrid32<T> gx)
            where T : unmanaged
                => math.not(gx);

        [MethodImpl(Inline)]
        public static BitGrid64<T> not<T>(BitGrid64<T> gx)
            where T : unmanaged
                => math.not(gx);

        [MethodImpl(Inline)]
        public static BitGrid128<T> not<T>(in BitGrid128<T> gx)
            where T : unmanaged
                => ginx.vnot<T>(gx);

        [MethodImpl(Inline)]
        public static BitGrid256<T> not<T>(in BitGrid256<T> gx)
            where T : unmanaged
                => ginx.vnot<T>(gx);

    }
}
