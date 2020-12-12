//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Sources
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ConstTriple<T> ktriple<T>(ISource source, T t = default)
            where T : struct
                => (one(source, t), one(source, t), one(source, t));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ConstTriple<T> ktriple<T>(IDomainSource source, T min, T max)
            where T : unmanaged
                => (next(source,min,max), next(source,min,max), next(source,min,max));
    }
}