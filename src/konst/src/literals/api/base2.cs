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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NumericLiteral<T> base2<T>(string Name, T Value, string Text)
            where T : unmanaged
                => new NumericLiteral<T>(Name, Value, Text, NumericBaseKind.Base2);
    }
}