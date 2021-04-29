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
    using static memory;
    using static SFx;

    partial struct Calcs
    {

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Clamp<T> clamp<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Clamp, Closures(Integers)]
        public static Span<T> clamp<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(Calcs.clamp<T>(), l, r, dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ModMul<T> modmul<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Dist<T> dist<T>()
            where T : unmanaged
                => default;


        [MethodImpl(Inline), ModMul, Closures(Integers)]
        public static Span<T> modmul<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst)
            where T : unmanaged
                => apply(Calcs.modmul<T>(), a,b,c, dst);
    }
}