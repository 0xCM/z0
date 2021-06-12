//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using C = AsciCode;

    partial struct SymbolicQuery
    {
        [MethodImpl(Inline), Op]
        public static bool lparen(char c)
            => C.LParen == (C)c;

        [MethodImpl(Inline), Op]
        public static bool lparen(C c)
            => C.LParen == c;
    }
}