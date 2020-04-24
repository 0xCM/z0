//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static VSvcHosts;

    partial class VSvc
    {
        [MethodImpl(Inline)]
        public static Pop128<T> vpop<T>(N128 w, T t = default)
            where T : unmanaged
                => default(Pop128<T>);

        [MethodImpl(Inline)]
        public static Pop256<T> vpop<T>(N256 w, T t = default)
            where T : unmanaged
                => default(Pop256<T>);

        [MethodImpl(Inline)]
        public static TakeMask128<T> vtakemask<T>(N128 w, T t = default)
            where T : unmanaged
                => default(TakeMask128<T>);

        [MethodImpl(Inline)]
        public static TakeMask256<T> vtakemask<T>(N256 w, T t = default)
            where T : unmanaged
                => default(TakeMask256<T>);

        [MethodImpl(Inline)]
        public static TakeIMask128<T> vtakeimask<T>(N128 w, T t = default)
            where T : unmanaged
                => default(TakeIMask128<T>);

        [MethodImpl(Inline)]
        public static TakeIMask256<T> vtakeimask<T>(N256 w, T t = default)
            where T : unmanaged
                => default(TakeIMask256<T>);

    }
}