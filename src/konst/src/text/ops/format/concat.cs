//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct TextRules
    {
        partial struct Format
        {
            /// <summary>
            /// Joins the string representation of a sequence of items with no interspersed separator
            /// </summary>
            /// <param name="src">The values to be joined</param>
            [MethodImpl(Inline), Op]
            public static string concat(params object[] src)
                => string.Concat(src);

            /// <summary>
            /// Concatenates a sequence of strings, padding each to a specified width and interspersed with a specified delimiter
            /// </summary>
            /// <param name="src">The text to join</param>
            /// <param name="widths">The corresponding widths</param>
            /// <param name="delimiter">The delimiter to use</param>
            [Op]
            public static string concat(ReadOnlySpan<string> src, ReadOnlySpan<byte> widths, char delimiter = FieldDelimiter)
            {
                var dst = text.build();
                var count = z.length(src,widths);
                for(var i=0u; i<count; i++)
                {
                    ref readonly var field = ref skip(src,i);
                    ref readonly var width = ref skip(widths,i);
                    dst.Append(field.PadRight(width));
                    if(i != count - 1)
                    {
                        dst.Append(delimiter);
                        dst.Append(Chars.Space);
                    }
                }
                return dst.ToString();
            }
        }
    }
}