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
            public static bit cr(char c)
                => (ushort)AsciChar.CR == (ushort)c;
        }
    }
}