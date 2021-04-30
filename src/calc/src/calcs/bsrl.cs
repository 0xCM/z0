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
        [MethodImpl(Inline), Bsrl, Closures(Integers)]
        public static ref readonly SpanBlock128<T> bsrl<T>(in SpanBlock128<T> a, [Imm] byte count, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref bsrl<T>(w128).Invoke(a, count, dst);

        [MethodImpl(Inline), Bsrl, Closures(Integers)]
        public static ref readonly SpanBlock256<T> brsl<T>(in SpanBlock256<T> a, [Imm] byte count, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref bsrl<T>(w256).Invoke(a, count, dst);
    }
}