//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using AC = AsciChar;

    partial struct TextQuery
    {
        [MethodImpl(Inline), Op]
        public static bit newline(char c)
            => (ushort)AsciCharCode.LF == (ushort)c
            || (ushort)AsciCharCode.CR == (ushort)c;
    }
}