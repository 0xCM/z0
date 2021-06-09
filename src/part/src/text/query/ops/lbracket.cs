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
    using CC = AsciCode;

    partial struct TextQuery
    {
        [MethodImpl(Inline), Op]
        public static bool lbracket(char src)
            => AC.LBracket == (AC)src;

        [MethodImpl(Inline), Op]
        public static bool lbracket(CC src)
            => AC.LBracket == (AC)src;
    }
}