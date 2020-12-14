//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost("dsl.units")]
    public readonly struct Units
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Branch<T> branch<T>(Predicate<T> test, Action<T> sat, Action<T> unsat)
            => new Branch<T>(test, sat, unsat);
    }
}