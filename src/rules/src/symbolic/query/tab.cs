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
        public static bool tab(char c)
            => C.Tab == (C)c;

        [MethodImpl(Inline), Op]
        public static bool tab(C c)
            => C.Tab == c;
    }
}