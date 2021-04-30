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
    using static ApiClassKind;

    partial struct Calcs
    {
        [MethodImpl(Inline), Factory(Bsll), Closures(Integers)]
        public static Bsll128<T> bsll<T>(W128 w)
            where T : unmanaged
                => default(Bsll128<T>);

        [MethodImpl(Inline), Factory(Bsll), Closures(Integers)]
        public static Bsll256<T> bsll<T>(W256 w)
            where T : unmanaged
                => default(Bsll256<T>);

        [MethodImpl(Inline), Bsll, Closures(Integers)]
        public static ref readonly SpanBlock128<T> bsll<T>(in SpanBlock128<T> a, [Imm] byte count, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref bsll<T>(w128).Invoke(a, count, dst);

        [MethodImpl(Inline), Bsll, Closures(Integers)]
        public static ref readonly SpanBlock256<T> bsll<T>(in SpanBlock256<T> a, [Imm] byte count, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref bsll<T>(w256).Invoke(a, count, dst);
    }
}