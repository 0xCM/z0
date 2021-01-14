//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using NBK = NumericBaseKind;

    partial struct Numeric
    {
        [MethodImpl(Inline), Op]
        public static NumericLiteral literal(string Name, object Value, string Text, NBK @base)
            => new NumericLiteral(Name,Value,Text, @base);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NumericLiteral<T> literal<T>(string Name, T data, string Text, NBK @base)
            where T : unmanaged
                => new NumericLiteral<T>(Name,data, Text, @base);
    }
}