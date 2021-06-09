//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct TextQuery
    {
        [MethodImpl(Inline), Op]
        public static bool newline(char c)
            => (ushort)AsciCode.LF == (ushort)c
            || (ushort)AsciCode.CR == (ushort)c;
    }
}