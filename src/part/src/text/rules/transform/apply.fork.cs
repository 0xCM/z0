//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static Rules;

    partial struct TextRules
    {
        partial struct Transform
        {
            /// <summary>
            /// Applies a specified rule to partition a source string into two disjoint pieces
            /// that exclude the branch criterion character.
            /// </summary>
            /// <param name="rule">The transformation rule</param>
            /// <param name="src">The source string</param>
            [Op]
            public static Pair<string> apply(Fork<char> rule, string src)
                => root.pair(Parse.before(src, rule.Criterion), Parse.after(src, rule.Criterion));
        }
    }
}