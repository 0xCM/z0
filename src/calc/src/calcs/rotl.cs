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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock128<T> rotl<T>(in SpanBlock128<T> a, [Imm] byte count, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref rotl<T>(w128).Invoke(a, count, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock256<T> rotl<T>(in SpanBlock256<T> a, [Imm] byte count, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref rotl<T>(w256).Invoke(a, count, dst);
    }
}