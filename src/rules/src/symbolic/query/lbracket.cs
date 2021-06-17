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

    partial struct TextQuery
    {
        [MethodImpl(Inline), Op]
        public static bool lbracket(C src)
            => C.LBracket == src;

        [MethodImpl(Inline), Op]
        public static bool lbracket(char src)
            => (char)C.LBracket == src;
    }
}