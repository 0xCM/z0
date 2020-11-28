//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Sources
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T one<T>(ISource src, T t = default)
            where T : struct
                => src.Next<T>();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T one<T>(IRefSource<T> src)
            where T : struct
                => ref src.Next();
    }
}