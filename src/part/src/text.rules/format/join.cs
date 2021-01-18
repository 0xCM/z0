//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct TextRules
    {
        partial struct Format
        {
            /// <summary>
            /// Concatenates a sequence of <typeparamref name='T'/> cells from a source span using a specified delimiter
            /// </summary>
            /// <param name="delimiter">The cell delimiter</param>
            /// <param name="src">The cell source</param>
            /// <typeparam name="T">The cell type</typeparam>
            [MethodImpl(Inline), Op, Closures(Closure)]
            public static string join<T>(string delimiter, ReadOnlySpan<T> src)
            {
                var dst = text.buffer();
                var count = src.Length;
                for(var i=0u; i<count; i++)
                {
                    dst.AppendCell(skip(src, i));
                    if(i != count-1)
                        dst.Append(delimiter);
                }
                return dst.ToString();
            }

            /// <summary>
            /// Functional equivalalent of <see cref="string.Join(string, object[])"/>
            /// </summary>
            /// <param name="values">The values to be rendered as text</param>
            /// <param name="sep">The item delimiter</param>
            [MethodImpl(Inline), Op, Closures(Closure)]
            public static string join<T>(string sep, IEnumerable<T> values)
                => string.Join(sep, values);

            /// <summary>
            /// Functional equivalalent of <see cref="string.Join(char, object[])"/>
            /// </summary>
            /// <param name="values">The values to be rendered as text</param>
            /// <param name="sep">The item delimiter</param>
            [MethodImpl(Inline), Op, Closures(Closure)]
            public static string join<T>(char sep, IEnumerable<T> values)
                => string.Join(sep, values);
        }
    }
}