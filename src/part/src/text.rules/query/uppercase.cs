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
            /// Determines whether the source value is one of <see cref='AsciLetterUpCode'/>
            /// </summary>
            /// <param name="src">The value to test</param>
            [MethodImpl(Inline), Op]
            public static bit uppercase(C src)
                => contains(F.MinUpperCode, F.MaxUpperCode, src);

            /// <summary>
            /// Determines whether the code of a specified character is one of <see cref='AsciLetterUpCode'/>
            /// </summary>
            /// <param name="src">The value to test</param>
            [MethodImpl(Inline), Op]
            public static bit uppercase(char src)
                => uppercase((C)src);
        }
    }
}