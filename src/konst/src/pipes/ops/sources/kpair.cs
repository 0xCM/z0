//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Sources
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ConstPair<T> kpair<T>(IDataSource source, T t = default)
            where T : struct
                => (next<T>(source), next<T>(source));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ConstPair<T> kpair<T>(IDomainSource source, T min, T max)
            where T : unmanaged
                => (next(source, min, max), next(source, min, max));
    }
}