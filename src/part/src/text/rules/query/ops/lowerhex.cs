//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using C = AsciCharCode;
    using XF = HexSymFacet;
    using AC = AsciChar;

    partial struct TextQuery
    {
        [MethodImpl(Inline), Op]
        public static bit lowerhex(char src)
            => ((XF)src >= XF.FirstNumber && (XF)src <= XF.LastNumber)
            || ((XF)src >= XF.FirstLetterLo && (XF)src <= XF.LastLetterLo);

    }
}