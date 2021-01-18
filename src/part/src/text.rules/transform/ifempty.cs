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
        partial struct Transform
        {

            /// <summary>
            /// Returns the replacement text if the source text is blank := {null | empty}
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="replace">The replacement value if blank</param>
            [MethodImpl(Inline), Op]
            public static string ifempty(string src, string replace)
                => Query.empty(src) ? replace ?? EmptyString : src;
        }
    }
}