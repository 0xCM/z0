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
        public static bool vtab(char c)
            => C.VTab == (C)c;

        [MethodImpl(Inline), Op]
        public static bool vtab(C c)
            => C.VTab == c;
    }
}