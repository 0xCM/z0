//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct BitSeq
    {
        [MethodImpl(Inline), Op]
        public static uint2 inc(uint2 x)
            => !x.IsMax ? new uint2(z.add(x.data, 1), false) : uint2.Min;


        [MethodImpl(Inline), Op]
        public static uint3 inc(uint3 x)
            => !x.IsMax ? new uint3(z.add(x.data, 1), false) : uint3.Min;


        [MethodImpl(Inline), Op]
        public static uint4 inc(uint4 x)
            => !x.IsMax ? new uint4(z.add(x.data, 1), false) : uint4.Min;


        [MethodImpl(Inline), Op]
        public static uint5 inc(uint5 x)
            => !x.IsMax ? new uint5(z.add(x.data, 1), false) : uint5.Min;


        [MethodImpl(Inline), Op]
        public static uint6 inc(uint6 x)
            => !x.IsMax ? new uint6(z.add(x.data, 1), false) : uint6.Min;


        [MethodImpl(Inline), Op]
        public static uint7 inc(uint7 x)
            => !x.IsMax ? new uint7(z.add(x.data, 1), false) : uint7.Min;
            
        [MethodImpl(Inline), Op]
        public static octet inc(octet x)
            => !x.IsMax ? new octet(z.add(x.data, 1)) : octet.Min;
    }
}