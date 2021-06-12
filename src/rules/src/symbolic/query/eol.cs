//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using static AsciCode;

    using C = AsciCode;

    partial struct SymbolicQuery
    {
        [MethodImpl(Inline), Op]
        public static bool eol(byte a0, byte a1)
            => (C)a0 == CR || (C)a1 == LF;

        [MethodImpl(Inline), Op]
        public static bool eol(char a, char b)
            => cr(a) && lf(b);
    }
}