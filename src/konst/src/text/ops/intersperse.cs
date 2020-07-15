//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.IO;

    using static Konst;
    using static z;

    partial class text
    {
        /// <summary>
        /// Creates a new string by weaving a specified character between each character in the source
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="c">The character to intersperse</param>
        public static string intersperse(string src, char c)
            => src.Intersperse(c);
        
        /// <summary>
        /// Creates a new string by weaving a substring between each character in the source
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="sep">The value to intersperse</param>
        public static string intersperse(string src, string sep)
            => src.Intersperse(sep);
            
        /// <summary>
        /// Intersperses the source strings with a delimiter followed by a space, i.e.,
        /// result := "{s1}{delimiter} {s2}{delimiter} ... {sn}{delimiter}"
        /// </summary>
        /// <param name="fields">The fields to delimit</param>
        /// <param name="delimiter">The delimiter to use</param>
        public static string intersperse(ReadOnlySpan<string> fields, char delimiter = FieldDelimiter)
        {
            var dst = text.build();
            var count = fields.Length;
            for(byte i=0; i<count; i++)
            {
                dst.Append(z.skip(fields, i));
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