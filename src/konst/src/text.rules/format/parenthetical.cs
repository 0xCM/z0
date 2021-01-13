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
        partial struct Format
        {
            /// <summary>
            /// Encloses content between '(' and ')' characters
            /// </summary>
            /// <param name="content">The items to be enclosed</param>
            [MethodImpl(Inline), Op]
            public static string parenthetical(params object[] content)
                => enclose(string.Concat(content.Select(x => x.ToString())), Chars.LParen, Chars.RParen);

            /// <summary>
            /// Encloses text between '[' and ']' characters
            /// </summary>
            /// <param name="content">The content to enclose</param>
            [MethodImpl(Inline), Op]
            public static string bracket(object content)
                => enclose($"{content}", Chars.LBracket, Chars.RBracket);

            /// <summary>
            /// Appends a space to the source content
            /// </summary>
            /// <param name="content">The source content</param>
            [MethodImpl(Inline), Op]
            public static string rspace(object content)
                => $"{content} ";

            /// <summary>
            /// Creates a string of the form "name: content"
            /// </summary>
            /// <param name="name">The label name</param>
            /// <param name="content">The labeled content</param>
            [MethodImpl(Inline), Op]
            public static string label(object name, object content)
                => concat(name, Chars.Colon, Space, content);
        }
    }
}