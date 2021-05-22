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
        public static bit lbrace(char src)
            => AC.LBrace == (AC)src;

        [MethodImpl(Inline), Op]
        public static bit lbrace(CC src)
            => AC.LBrace == (AC)src;
    }
}