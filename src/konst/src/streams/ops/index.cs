//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct Sourced
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Triples<T> index<T>(IValueSource source, Triple<T>[] buffer, T t = default)
            where T : struct
                => store(Sourced.triples(source, t).Take(buffer.Length),buffer);
    }
}