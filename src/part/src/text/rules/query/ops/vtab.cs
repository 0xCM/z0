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
        public static bit vtab(char c)
            => AC.VTab == (AC)c;

        [MethodImpl(Inline), Op]
        public static bit vtab(CC c)
            => AC.VTab == (AC)c;
    }
}