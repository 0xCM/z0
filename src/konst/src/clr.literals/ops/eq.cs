//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ClrLiterals
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

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool eq<T>(LiteralValue<T> a, LiteralValue<T> b)
            where T : IEquatable<T>
                => a.Value?.Equals(b.Value) ?? false;
    }
}