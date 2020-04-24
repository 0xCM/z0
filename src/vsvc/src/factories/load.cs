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
        public static LoadSpan128<T> vloadspan<T>(N128 w, T t = default)
            where T : unmanaged
                => default(LoadSpan128<T>);

        [MethodImpl(Inline)]
        public static LoadSpan256<T> vloadspan<T>(N256 w, T t = default)
            where T : unmanaged
                => default(LoadSpan256<T>);
    }
}