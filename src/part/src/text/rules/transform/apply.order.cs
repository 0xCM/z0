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

    partial struct TextRules
    {
        partial struct Transform
        {
            /// <summary>
            /// Creates a hashset from an input sequence
            /// </summary>
            /// <param name="rule">The rule specification</param>
            /// <param name="src">The input sequence</param>
            [MethodImpl(Inline), Op]
            public static Index<string> order(Ordered<string> rule, Index<string> src)
                => src.Sort();
        }
    }
}