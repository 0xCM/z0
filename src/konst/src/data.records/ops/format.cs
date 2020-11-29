//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct Records
    {
        [Op, Closures(Closure)]
        public static Span<byte> format<T>(in T src)
            where T : struct
                => z.bytes(src);
    }
}