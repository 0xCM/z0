//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;
    using static HexSpecs;

    partial class Hex
    {
        [MethodImpl(Inline), Op]
        public static HexDigitKind classify(char src)
        {
            var @class = HexDigitKind.None;
            if(isNumber(src))
                return HexDigitKind.Number;
            else if(isUpper(src))
                return HexDigitKind.UpperLetter;
            else if(isLower(src))
                return HexDigitKind.LowerLetter;
            else
                return 0;            ;
        }
    }
}