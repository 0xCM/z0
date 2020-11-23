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
        public static uint6 dec(uint6 x)
            => !x.IsMin ? new uint6(Bytes.sub(x.data, 1), false) : Z0.uint6.Max;

        [MethodImpl(Inline), Op]
        public static uint7 dec(uint7 x)
            => !x.IsMin ? new uint7(Bytes.sub(x.data, 1), false) : Z0.uint7.Max;

        [MethodImpl(Inline), Op]
        public static octet dec(octet x)
            => !x.IsMin ? new octet(Bytes.sub(x.data, 1)) : Z0.octet.Max;
    }
}