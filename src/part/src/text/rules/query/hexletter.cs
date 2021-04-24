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
            /// Determines whether a <see cref='C'/> code is within the range [a..f] or the range [A..F]
            /// </summary>
            /// <param name="src">The value to test</param>
            [MethodImpl(Inline), Op]
            public static bit hexletter(C src)
                => text.between(src, C.a, C.f) || text.between(src,C.A, C.B);

            /// <summary>
            /// Determines whether a <see cref='char'/> is within the range [a..f] or the range [A..F]
            /// </summary>
            /// <param name="src">The value to test</param>
            [MethodImpl(Inline), Op]
            public static bit hexletter(char src)
                => hexletter((C)src);
        }
    }
}