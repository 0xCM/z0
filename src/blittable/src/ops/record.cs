//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct BitFlow
    {
        [MethodImpl(Inline), Op]
        public static Record record(byte[] src)
            => new Record(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Record<T> record<T>(T src)
            where T : unmanaged
                => new Record<T>(src);
    }
}