//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static memory;

    partial struct TextRules
    {
        partial struct Format
        {
            [Op, Closures(Closure)]
            public static string delimit<T>(T[] items, char delimiter)
                => delimit(@readonly(items), delimiter);

            public static string delimit<T>(ReadOnlySpan<T> src, char delimiter)
            {
                var dst = build();
                var count = src.Length;
                for(var i=0; i<count; i++)
                {
                    if(i != 0)
                    {
                        dst.Append(delimiter);
                        dst.Append(Chars.Space);
                    }

                    dst.Append(skip(src,i));
                }
                return dst.ToString();
            }

            public static string delimit<T>(ReadOnlySpan<T> src, char delimiter, int pad)
            {
                var dst = text.buffer();
                var count = src.Length;
                var slot = RP.pad(pad);
                for(var i=0; i<count; i++)
                {
                    dst.AppendFormat(slot, skip(src,i));
                    if(i != 0)
                    {
                        dst.Append(delimiter);
                        dst.Append(Chars.Space);
                    }
                }
                return dst.Emit();
            }

            /// <summary>
            /// Formats a sequence of formattable things as delimited list
            /// </summary>
            /// <param name="src">The source span</param>
            /// <param name="delimiter">The delimiter, if specified; otherwise, a system default is chosen</param>
            /// <param name="offset">The index of the source element at which formatting will begin</param>
            /// <typeparam name="T">A formattable type</typeparam>
            public static string delimit<T>(IEnumerable<T> src, char delimiter)
                => string.Join($"{delimiter} ", src);
        }
    }
}