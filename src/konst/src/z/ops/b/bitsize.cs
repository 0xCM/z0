//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static uint bitwidth<T>(T t = default)
            => (uint)SizeOf<T>() * 8;
    }
}