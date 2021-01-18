//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct TextRules
    {
        partial struct Query
        {
            /// <summary>
            /// Compares the source operands via the default <see cref='IComparable'/> implementation by the <see cref'string'/> type
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Op]
            public static int compare(string a, string b)
                => a?.CompareTo(b) ?? 0;
        }
    }
}