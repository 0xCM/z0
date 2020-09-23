//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Sourced
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T one<T>(IValueSource src, T t = default)
            where T : struct
                => src.Next<T>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly T one<T>(ICachedSource<T> src)
            where T : struct
                => ref src.Next();
    }
}