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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NumericLiteral<T> base2<T>(string name, T value, string text)
            where T : unmanaged
                => new NumericLiteral<T>(name, value, text, NumericBaseKind.Base2);
    }
}