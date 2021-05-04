//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CalcHosts;
    using static SFx;

    partial struct Calcs
    {
        [MethodImpl(Inline), Factory, Closures(Closure)]
        public static ModOp<T> mod<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Mod, Closures(Closure)]
        public static Span<T> mod<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(Calcs.mod<T>(), l, r, dst);
    }
}