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
        public static Square<T> square<T>()
            where T : unmanaged
                => default;

       [MethodImpl(Inline), Square, Closures(Integers)]
        public static Span<T> square<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => apply(Calcs.square<T>(), src, dst);
    }
}