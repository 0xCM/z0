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
        /// Concatenates a sequence of values with no intervening delimiter
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        [MethodImpl(Inline), Op]
        public static string concat(IEnumerable<object> src)
            => string.Concat(src);

        /// <summary>
        /// Concatenates a sequence of characters with no intervening delimiter
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        [MethodImpl(Inline), Op]
        public static string concat(IEnumerable<char> src)
            => string.Concat(src);

        /// <summary>
        /// Concatenates a sequence of strings interspersed by a character delimiter with a space on either side
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        [MethodImpl(Inline), Op]
        public static string concat(char sep, IEnumerable<object> src)
            => string.Join(spaced(sep), src);

        /// <summary>
        /// Joins the string representation of a sequence of items interspersed by a separator
        /// </summary>
        /// <param name="sep">The value delimiter</param>
        /// <param name="src">The values to be joined</param>
        [MethodImpl(Inline), Op]
        public static string concat(string sep, IEnumerable<object> src)
            => string.Join(sep, src);

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