//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    unsafe partial struct Pointers
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string format<T>(Ptr<T> src)
            where T : unmanaged
                => src.Address.Format();
    }
}