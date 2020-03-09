//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static VSvcHosts;

    partial class VSvcFactories
    {
        [MethodImpl(Inline)]
        public static Ones128<T> vones<T>(N128 w, T t = default)
            where T : unmanaged
                => Ones128<T>.Op;

        [MethodImpl(Inline)]
        public static Ones256<T> vones<T>(N256 w, T t = default)
            where T : unmanaged
                => Ones256<T>.Op;

        [MethodImpl(Inline)]
        public static Units128<T> vunits<T>(N128 w, T t = default)
            where T : unmanaged
                => Units128<T>.Op;

        [MethodImpl(Inline)]
        public static Units256<T> vunits<T>(N256 w, T t = default)
            where T : unmanaged
                => Units256<T>.Op;
    }
}