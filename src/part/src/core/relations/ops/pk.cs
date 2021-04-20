//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Relations
    {
        [MethodImpl(Inline)]
        public static PK<I,T> pk<I,T>(T row, I value)
            where T : struct
            where I : unmanaged
                => new PK<I,T>(value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static PK<I> pk<I>(I value)
            where I : unmanaged
                => new PK<I>(value);

        [MethodImpl(Inline), Op]
        public static PK pk(ulong value)
            => new PK(value);

    }
}