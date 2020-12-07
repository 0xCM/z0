//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class text
    {
        /// <summary>
        /// Functional equivalalent of <see cref="string.Join(string, object[])"/>
        /// </summary>
        /// <param name="values">The values to be rendered as text</param>
        /// <param name="sep">The item delimiter</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string join<T>(string sep, IEnumerable<T> values)
            => string.Join(sep, values);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string join<T>(string sep, ReadOnlySpan<T> values)
        {
            var dst = build();
            var count = values.Length;
            for(var i=0u; i<count; i++)
            {
                dst.Append(skip(values,i));
                if(i != count - 1)
                    dst.Append(sep);
            }
            return dst.ToString();
        }

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