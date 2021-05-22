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
    using CC = AsciCharCode;

    partial struct TextQuery
    {
        [MethodImpl(Inline), Op]
        public static bit rparen(char c)
            => AC.RParen == (AC)c;

        [MethodImpl(Inline), Op]
        public static bit rparen(CC c)
            => AC.RParen == (AC)c;
    }
}