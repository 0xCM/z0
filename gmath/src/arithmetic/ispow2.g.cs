//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
                
    using static Seed; using static Memories;

    partial class gmath
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static bit ispow2<T>(T src)
            where T : unmanaged
                => math.ispow2(convert<T,ulong>(src));
    }
}