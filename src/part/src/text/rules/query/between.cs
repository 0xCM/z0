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

    partial struct TextRules
    {
        partial struct Query
        {
            /// <summary>
            /// Determines whether a specified <see cref='C'/> code is between a specified <see cref='C'/> minimum and <see cref='C'/> maximum
            /// </summary>
            /// <param name="src">The value to test</param>
            /// <param name="min">The inclusive lower bound</param>
            /// <param name="max">The inclusive upper bound</param>
            [MethodImpl(Inline), Op]
            public static bool between(C src, C min, C max)
                => src >= min && src <= max;

            /// <summary>
            /// Determines whether a specified <see cref='char'/> is between a specified <see cref='char'/> minimum and <see cref='char'/> maximum
            /// </summary>
            /// <param name="src">The value to test</param>
            /// <param name="min">The inclusive lower bound</param>
            /// <param name="max">The inclusive upper bound</param>
            [MethodImpl(Inline), Op]
            public static bool between(char src, char min, char max)
                => between((C)src, (C)min, (C)max);
        }
    }
}