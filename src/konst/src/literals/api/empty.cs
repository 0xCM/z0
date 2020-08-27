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
        public static bool empty(in BinaryLiteral src)
            => BinaryLiteral.empty(src);

        [MethodImpl(Inline), Op, Closures(Integers8x64k)]
        public static bool empty<T>(in BinaryLiteral<T> src)
            where T : unmanaged
                => BinaryLiteral.empty(src);
    }
}