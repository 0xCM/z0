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
                => string.Equals(x.Text, y.Text)
                && object.Equals(x.Data, y.Data)
                && string.Equals(x.Name, y.Name);

        [MethodImpl(Inline), Op]
        public static bool eq(BinaryLiteral x, BinaryLiteral y)
                => string.Equals(x.Text, y.Text)
                && object.Equals(x.Data, y.Data)
                && string.Equals(x.Name, y.Name);
    }
}