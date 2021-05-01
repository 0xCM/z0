//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using static HexDigitKind;

    partial struct Hex
    {
        [MethodImpl(Inline), Op]
        public static HexDigitKind kind(char src)
        {
            var @class = None;
            if(scalar(src))
                return Number;
            else if(upper(src))
                return UpperLetter;
            else if(lower(src))
                return LowerLetter;
            else
                return 0;
        }
    }
}