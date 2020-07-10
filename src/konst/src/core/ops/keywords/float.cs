//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {                
        [MethodImpl(Inline), Op]
        public static unsafe float @float(bool on)
            => *((byte*)(&on));

        [MethodImpl(Inline), Op, Closures(Numeric32x64k)]
        public static unsafe float @float<T>(T src)
            where T : unmanaged             
                => *((float*)(&src));
    }
}