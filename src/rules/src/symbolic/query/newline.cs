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

    using C = AsciCode;

    partial struct SymbolicQuery
    {
        [MethodImpl(Inline), Op]
        public static bool newline(char c)
            => (char)C.LF == c || (char)C.CR == c;
    }
}