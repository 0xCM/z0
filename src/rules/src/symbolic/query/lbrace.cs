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
        public static bit lbrace(char src)
            => C.LBrace == (C)src;

        [MethodImpl(Inline), Op]
        public static bit lbrace(C src)
            => C.LBrace == src;
    }
}