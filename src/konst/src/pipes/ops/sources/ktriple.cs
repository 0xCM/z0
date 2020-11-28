//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct Sources
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ConstTriple<T> ktriple<T>(ISource source, T t = default)
            where T : struct
                => (one(source, t), one(source, t), one(source, t));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ConstTriple<T> ktriple<T>(IDomainValueSource source, T min, T max)
            where T : unmanaged
                => (next(source,min,max), next(source,min,max), next(source,min,max));
    }
}