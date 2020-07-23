//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    
    partial struct SegRefs
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Ref<T> @ref<T>(in T src, uint size)
            => new Ref<T>(new Ref(z.address(src), size));
    }
}