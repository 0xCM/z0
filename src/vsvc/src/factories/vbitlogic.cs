//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static VSvcHosts;

    partial class VSvc
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitLogic128<T> vbitlogic<T>(N128 w, T t = default)
            where T : unmanaged
                => default(BitLogic128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitLogic256<T> vbitlogic<T>(N256 w, T t = default)
            where T : unmanaged
                => default(BitLogic256<T>);
    }
}