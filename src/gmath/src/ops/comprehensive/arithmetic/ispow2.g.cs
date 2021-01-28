//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Numeric;

    partial class gmath
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Bit32 ispow2<T>(T src)
            where T : unmanaged
                => math.ispow2(force<T,ulong>(src));
    }
}