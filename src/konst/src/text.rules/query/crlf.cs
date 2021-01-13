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
            /// Tests whether a source character is a <see cref='AsciChar.CR'/>
            /// </summary>
            /// <param name="c">The character to test</param>
            [MethodImpl(Inline), Op]
            public static bool cr(char c)
                => (ushort)AsciChar.CR == (ushort)c;

            /// <summary>
            /// Tests whether a source character is a <see cref='AsciChar.LF'/>
            /// </summary>
            /// <param name="c">The character to test</param>
            [MethodImpl(Inline), Op]
            public static bool lf(char c)
                => (ushort)AsciChar.LF == (ushort)c;

            /// <summary>
            /// Tests whether a source character is a <see cref='AsciChar.CR'/> followed by a <see cref='AsciChar.LF'/>
            /// </summary>
            /// <param name="c">The character to test</param>
            [MethodImpl(Inline), Op]
            public static bool crlf(char a, char b)
                => cr(a) && lf(b);
        }
    }
}