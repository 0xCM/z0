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
        public static bool rbracket(C src)
            => C.RBracket == src;

        [MethodImpl(Inline), Op]
        public static bool rbracket(char src)
            => (char)C.RBracket == src;
    }
}