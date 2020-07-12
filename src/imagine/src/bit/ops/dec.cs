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

    partial class Bit
    {
        [MethodImpl(Inline), Op]
        public static uint2 dec(uint2 x)
            => !x.IsMin ? new uint2(z.sub(x.data, 1), false) : Q.uint2.Max;

        [MethodImpl(Inline), Op]
        public static uint3 dec(uint3 x)
            => !x.IsMin ? new uint3(z.sub(x.data, 1), false) : Q.uint3.Max;

        [MethodImpl(Inline), Op]
        public static uint4 dec(uint4 x)
            => !x.IsMin ? new uint4(z.sub(x.data, 1), false) : Q.uint4.Max;

        [MethodImpl(Inline), Op]
        public static uint5 dec(uint5 x)
            => !x.IsMin ? new uint5(z.sub(x.data, 1), false) : Q.uint5.Max;

        [MethodImpl(Inline), Op]
        public static uint6 dec(uint6 x)
            => !x.IsMin ? new uint6(z.sub(x.data, 1), false) : Q.uint6.Max;

        [MethodImpl(Inline), Op]
        public static uint7 dec(uint7 x)
            => !x.IsMin ? new uint7(z.sub(x.data, 1), false) : Q.uint7.Max;

        [MethodImpl(Inline), Op]
        public static octet dec(octet x)
            => !x.IsMin ? new octet(z.sub(x.data, 1)) : Q.octet.Max;            
    }
}