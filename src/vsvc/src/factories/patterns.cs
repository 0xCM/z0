//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static VServices;

    partial class VSvc
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Ones128<T> vones<T>(N128 w, T t = default)
            where T : unmanaged
                => default(Ones128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Ones256<T> vones<T>(N256 w, T t = default)
            where T : unmanaged
                => default(Ones256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Units128<T> vunits<T>(N128 w, T t = default)
            where T : unmanaged
                => default(Units128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Units256<T> vunits<T>(N256 w, T t = default)
            where T : unmanaged
                => default(Units256<T>);
    }
}