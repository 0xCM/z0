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
        public static bit vtab(C c)
            => C.VTab == c;

        [MethodImpl(Inline), Op]
        public static bit vtab(char c)
            => (char)C.VTab == c;
    }
}