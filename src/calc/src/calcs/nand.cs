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
        [MethodImpl(Inline), Nand, Closures(Closure)]
        public static ref readonly SpanBlock128<T> nand<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.nand<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Nand, Closures(Closure)]
        public static ref readonly SpanBlock256<T> nand<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.nand<T>(w256).Invoke(a, b, dst);


    }
}