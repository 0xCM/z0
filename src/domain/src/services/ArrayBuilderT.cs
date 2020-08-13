//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct ArrayBuilder
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ArrayBuilder<T> Create<T>(int? capacity = null)
            => new ArrayBuilder<T>(capacity ?? 128);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ArrayBuilder<T> Create<T>(params T[] src)
            => new ArrayBuilder<T>(src);
    }
}