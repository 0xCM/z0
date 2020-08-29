//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Linq;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Refs
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Ref define(ulong location, uint size)
            => new Ref(location, size);

        [MethodImpl(Inline), Op]
        static unsafe Ref define(void* pSrc, ulong size)
            => new Ref((ulong)pSrc, (uint)size);

        [MethodImpl(Inline), Op]
        static unsafe Ref define(void* pSrc, int size)
            => new Ref((ulong)pSrc, (uint)size);
    }
}