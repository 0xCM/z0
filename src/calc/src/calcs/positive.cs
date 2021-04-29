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
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static PositiveOp<T> positive<T>()
            where T : unmanaged
                => default(PositiveOp<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static NegativeOp<T> negative<T>()
            where T : unmanaged
                => default(NegativeOp<T>);
    }
}