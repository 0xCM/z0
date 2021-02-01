//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Rules;
    using static memory;

    partial struct TextRules
    {
        partial struct Query
        {
            [MethodImpl(Inline), Op]
            public static bool test(char src, OneOf<char> match)
                => contains(match.Elements, src);
        }
    }
}