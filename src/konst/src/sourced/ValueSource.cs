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
    public readonly struct ValueSource
    {

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T next<T>(IValueSource src, T t = default)
            where T : struct
                => src.Next<T>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly T next<T>(ICachedSource<T> src)
            where T : struct
                => ref src.Next();
    }
}