//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct LiteralFields
    {
        [MethodImpl(Inline), Op]
        public static char[] chars(Type src)
            => z.map(search<char>(src), @char);
    }
}