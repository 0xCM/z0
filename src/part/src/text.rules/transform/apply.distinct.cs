//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static memory;
    using static Rules;

    partial struct TextRules
    {
        partial struct Transform
        {
            /// <summary>
            /// Creates a hashset from an input sequence
            /// </summary>
            /// <param name="rule">The rule specification</param>
            /// <param name="src">The input sequence</param>
            [Op]
            public static HashSet<string> apply(Distinct<string> rule, ReadOnlySpan<string> src)
            {
                var count = src.Length;
                var dst = root.hashset<string>(count);
                for(var i=0; i<count; i++)
                    dst.Add(skip(src,i));
                return dst;
            }
        }
    }
}