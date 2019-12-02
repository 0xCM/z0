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
        public static BitGrid32<T> ones<T>(N32 n, T zero = default)
            where T : unmanaged
                => uint.MaxValue;

        [MethodImpl(Inline)]
        public static BitGrid64<T> ones<T>(N64 n, T zero = default)
            where T : unmanaged
                => ulong.MaxValue;

        [MethodImpl(Inline)]
        public static BitGrid128<T> ones<T>(N128 n, T zero = default)
            where T : unmanaged
                => ginx.vpones<T>(n);

        [MethodImpl(Inline)]
        public static BitGrid256<T> ones<T>(N256 n, T zero = default)
            where T : unmanaged
                => ginx.vpones<T>(n);


    }
}
