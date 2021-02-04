//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class fmath
    {
        [MethodImpl(Inline), Op]
        public static BitsF32 bits(float src)
            => new BitsF32(src);

        [MethodImpl(Inline), Op]
        public static BitsF64 bits(double src)
            => new BitsF64(src);

        [MethodImpl(Inline), Op]
        public static BitsF128 bits(decimal src)
            => new BitsF128(src);
    }
}