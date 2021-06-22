//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct TextTools
    {
        /// <summary>
        /// Creates a new string by weaving a specified character between each character in the source
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="c">The character to intersperse</param>
        [Op]
        public static string intersperse(string src, char c)
        {
            var dst = TextTools.buffer();
            var input = span(src);
            var count = input.Length;
            for(var i=0u; i< count; i++)
            {
                dst.Append(skip(input,i));
                dst.Append(c);
            }

            return dst.Emit();
        }

        /// <summary>
        /// Creates a new string by weaving a substring between each character in the source
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="sep">The value to intersperse</param>
        [Op]
        public static string intersperse(string src, string sep)
        {
            var dst = TextTools.buffer();
            foreach(var item in src)
            {
                dst.Append(item);
                dst.Append(sep);
            }
            return dst.Emit();
        }

        [Op]
        public static string intersperse(string src, char c, uint frequency)
        {
            var count = src.Length;
            var j=0;
            var buffer = TextTools.buffer();
            for(var i=0; i<count; i++)
            {
                buffer.Append(src[i]);
                if(i != 0 && ((i - 1) % frequency ==0))
                    buffer.Append(c);
            }
            return buffer.Emit();
        }

        /// <summary>
        /// Intersperses the source strings with a delimiter followed by a space, i.e.,
        /// result := "{s1}{delimiter} {s2}{delimiter} ... {sn}{delimiter}"
        /// </summary>
        /// <param name="fields">The fields to delimit</param>
        /// <param name="delimiter">The delimiter to use</param>
        public static string intersperse(ReadOnlySpan<string> fields, char delimiter = FieldDelimiter)
        {
            var dst = TextTools.buffer();
            var count = fields.Length;
            for(byte i=0; i<count; i++)
            {
                dst.Append(skip(fields, i));
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