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
        public static uint2 dec(uint2 x)
            => !x.IsMin ? new uint2(core.sub(x.data, 1), false) : uint2.Max;

        [MethodImpl(Inline), Op]
        public static uint3 dec(uint3 x)
            => !x.IsMin ? new uint3(core.sub(x.data, 1), false) : uint3.Max;

        [MethodImpl(Inline), Op]
        public static uint4 dec(uint4 x)
            => !x.IsMin ? new uint4(core.sub(x.data, 1), false) : uint4.Max;

        [MethodImpl(Inline), Op]
        public static uint5 dec(uint5 x)
            => !x.IsMin ? new uint5(core.sub(x.data, 1), false) : uint5.Max;

        [MethodImpl(Inline), Op]
        public static uint6 dec(uint6 x)
            => !x.IsMin ? new uint6(core.sub(x.data, 1), false) : uint6.Max;

        [MethodImpl(Inline), Op]
        public static uint7 dec(uint7 x)
            => !x.IsMin ? new uint7(core.sub(x.data, 1), false) : uint7.Max;


        [MethodImpl(Inline), Op]
        public static octet dec(octet x)
            => !x.IsMin ? new octet(core.sub(x.data, 1)) : octet.Max;            
    }
}