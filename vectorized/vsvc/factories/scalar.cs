//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static root;
    using static VSvcHosts;

    partial class VSvc
    {
        [MethodImpl(Inline)]
        public static Pop128<T> vpop<T>(N128 w, T t = default)
            where T : unmanaged
                => Pop128<T>.Op;

        [MethodImpl(Inline)]
        public static Pop256<T> vpop<T>(N256 w, T t = default)
            where T : unmanaged
                => Pop256<T>.Op;

        [MethodImpl(Inline)]
        public static TakeMask128<T> vtakemask<T>(N128 w, T t = default)
            where T : unmanaged
                => TakeMask128<T>.Op;

        [MethodImpl(Inline)]
        public static TakeMask256<T> vtakemask<T>(N256 w, T t = default)
            where T : unmanaged
                => TakeMask256<T>.Op;

        [MethodImpl(Inline)]
        public static TakeIMask128<T> vtakeimask<T>(N128 w, T t = default)
            where T : unmanaged
                => TakeIMask128<T>.Op;

        [MethodImpl(Inline)]
        public static TakeIMask256<T> vtakeimask<T>(N256 w, T t = default)
            where T : unmanaged
                => TakeIMask256<T>.Op;

    }
}