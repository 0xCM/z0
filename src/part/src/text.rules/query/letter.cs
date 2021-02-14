//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using C = AsciCharCode;
    using F = AsciCodeFacets;

    partial struct TextRules
    {
        partial struct Query
        {
            /// <summary>
            /// Determines whether a specified code is one of <see cref='AsciLetterCode'/>
            /// </summary>
            /// <param name="src">The value to test</param>
            [MethodImpl(Inline), Op]
            public static bit letter(C src)
                => lowercase(src) || uppercase(src);

            /// <summary>
            /// Determines whether the code of a specified character is one of <see cref='AsciLetterCode'/>
            /// </summary>
            /// <param name="src">The value to test</param>
            [MethodImpl(Inline), Op]
            public static bit letter(char src)
                => letter((C)src);
        }
    }
}