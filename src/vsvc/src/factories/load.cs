//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static VServices;

    partial class VSvc
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LoadSpan128<T> vloadspan<T>(W128 w, T t = default)
            where T : unmanaged
                => default(LoadSpan128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LoadSpan256<T> vloadspan<T>(W256 w, T t = default)
            where T : unmanaged
                => default(LoadSpan256<T>);
    }
}