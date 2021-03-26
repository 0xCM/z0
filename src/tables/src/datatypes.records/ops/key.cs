//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct RecUtil
    {
        [MethodImpl(Inline)]
        public static RowKey<I,T> key<I,T>(T row, I value)
            where T : struct, IRecord<T>
            where I : unmanaged
                => new RowKey<I,T>(value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static RowKey<I> key<I>(I value)
            where I : unmanaged
                => new RowKey<I>(value);

        [MethodImpl(Inline), Op]
        public static RowKey key(ulong value)
            => new RowKey(value);
    }
}