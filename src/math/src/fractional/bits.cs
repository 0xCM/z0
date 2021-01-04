//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static math;
    using static memory;

    partial class fmath
    {
        [MethodImpl(Inline), Op]
        public static uint bits(float src)
            => @as<float,uint>(src);

        [MethodImpl(Inline), Op]
        public static ulong bits(double src)
            => @as<double,ulong>(src);

        [MethodImpl(Inline), Op]
        public static ulong lobits(decimal src)
            => @as<decimal,ulong>(src);

        [MethodImpl(Inline), Op]
        public static ulong hibits(decimal src)
            => skip(@as<decimal,ulong>(src), 1);
    }

}