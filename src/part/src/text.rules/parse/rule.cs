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
    using static Rules;

    partial struct TextRules
    {
        partial struct Parse
        {
            [Op]
            public static bool rule(string src, Adjacent<char, OneOf<char>> rule, out Adjacent<char> dst)
            {
                var match = rule.A;
                var candidates = rule.B.Elements.View;
                var count = candidates.Length;
                var ix = Query.index(candidates, rule.A);
                if(ix != NotFound)
                {
                    dst = adjacent<char>(match, skip(candidates,ix));
                    return true;
                }
                dst = default;
                return false;
            }
        }
    }
}