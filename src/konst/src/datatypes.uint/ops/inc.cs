//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Q = Z0;

    partial struct UI
    {

        [MethodImpl(Inline), Op]
        public static uint3 inc(uint3 x)
            => !x.IsMax ? new uint3(z.add(x.data, 1), false) : Q.uint3.Min;

        [MethodImpl(Inline), Op]
        public static uint4 inc(uint4 x)
            => !x.IsMax ? new uint4(z.add(x.data, 1), false) : Q.uint4.Min;

        [MethodImpl(Inline), Op]
        public static uint5 inc(uint5 x)
            => !x.IsMax ? new uint5(z.add(x.data, 1), false) : Q.uint5.Min;

        [MethodImpl(Inline), Op]
        public static uint6 inc(uint6 x)
            => !x.IsMax ? new uint6(z.add(x.data, 1), false) : Q.uint6.Min;

        [MethodImpl(Inline), Op]
        public static uint7 inc(uint7 x)
            => !x.IsMax ? new uint7(z.add(x.data, 1), false) : Q.uint7.Min;

        [MethodImpl(Inline), Op]
        public static uint8T inc(uint8T x)
            => !x.IsMax ? new uint8T(z.add(x.data, 1)) : Q.uint8T.Min;
    }
}