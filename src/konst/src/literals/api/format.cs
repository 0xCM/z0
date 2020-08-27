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

    partial struct Literals
    {
        [MethodImpl(Inline), Op]
        public static string format(BinaryLiteral src)
            => BinaryLiteral.format(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(BinaryLiteral<T> src)
            where T : unmanaged
                => BinaryLiteral.format(src);
    }
}