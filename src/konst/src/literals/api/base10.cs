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
        public static NumericLiteral<T> base10<T>(string Name, T data, string Text)
            where T : unmanaged
                => new NumericLiteral<T>(Name, data, Text, NumericBaseKind.Base10);
    }
}