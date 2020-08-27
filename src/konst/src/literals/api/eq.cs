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
        [MethodImpl(Inline), Op, Closures(Integers8x64k)]
        public static bool eq<T>(BinaryLiteral<T> x, BinaryLiteral<T> y)
            where T : unmanaged
                => BinaryLiteral.eq(x,y);

        [MethodImpl(Inline), Op]
        public static bool eq(BinaryLiteral x, BinaryLiteral y)
            => BinaryLiteral.eq(x,y);
    }
}