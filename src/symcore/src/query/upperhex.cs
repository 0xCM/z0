//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using XF = HexSymFacet;

    partial struct SymbolicQuery
    {
        [MethodImpl(Inline), Op]
        public static bool upperhex(char src)
            => ((XF)src >= XF.FirstNumber && (XF)src <= XF.LastNumber)
            || ((XF)src >= XF.FirstLetterUp && (XF)src <= XF.LastLetterUp);
    }
}