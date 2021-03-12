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
            /// Formats anything
            /// </summary>
            /// <param name="rest">The formattables to be rendered and concatenated</param>
            [MethodImpl(Inline), Op]
            public static string format(object src)
                => src is ITextual t ? t.Format() : src?.ToString() ?? "!!null!!";

            [Op]
            public static string format(object src, Type t, char delimiter, RenderWidth width)
                => text.rpad(text.format("{0} {1}", delimiter, text.format(src)), width);
        }
    }
}