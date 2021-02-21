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

            [Op, Closures(Closure)]
            public static string join<T>(string sep, ReadOnlySpan<T> src)
            {
                var dst = text.buffer();
                var count = src.Length;
                for(var i=0; i<count; i++)
                {
                    if(i != 0)
                        dst.Append(sep);
                    dst.AppendItem(skip(src,i));
                }
                return dst.ToString();
            }

            [Op, Closures(Closure)]
            public static string join<T>(string sep, T[] src)
                => join(sep, @readonly(src));
        }
    }
}