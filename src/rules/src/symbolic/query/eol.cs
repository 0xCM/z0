//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsciCode;

    using C = AsciCode;

    partial struct SymbolicQuery
    {
        [MethodImpl(Inline), Op]
        public static bit eol(byte a0, byte a1)
            => (C)a0 == CR && (C)a1 == LF;

        [MethodImpl(Inline), Op]
        public static bit eol(char a, char b)
            => cr(a) && lf(b);

        [MethodImpl(Inline), Op]
        public static bool eol(C a0, C a1)
            => a0 == CR && a1 == LF;

        [MethodImpl(Inline), Op]
        public static bit eol(AsciSymbol a0, AsciSymbol a1)
            => a0 == CR && a1 == LF;
    }
}