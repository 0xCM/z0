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
            /// Formats a pattern using an arbitrary kind/number of arguments
            /// </summary>
            /// <param name="pattern">The source pattern</param>
            /// <param name="args">The pattern arguments</param>
            [MethodImpl(Inline), Op]
            public static string format(string pattern, params object[] args)
                => string.Format(pattern, args);
        }
    }
}