//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Records
    {
        [Op, Closures(Closure)]
        public static Span<byte> format<T>(in T src)
            where T : struct, IRecord<T>
                => z.bytes(src);
    }
}