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
        /// Renders a content array as a comma-separated list of values
        /// </summary>
        /// <param name="content">The data to delimit and format</param>
        [MethodImpl(Inline), Op]
        public static string csv(object o1, object o2, params object[] content)
            => string.Join(Chars.Comma, o1, o2) + string.Join(Chars.Comma, content);

       /// <summary>
        /// Formats a sequence of formattable things as delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="sep">The delimiter, if specified; otherwise, a system default is chosen</param>
        /// <param name="offset">The index of the source element at which formatting will begin</param>
        /// <typeparam name="T">A formattable type</typeparam>
        public static string list<T>(ReadOnlySpan<T> src, char sep = Chars.Comma, int offset = 0)
            where T : ITextual
        {
            if(src.Length == 0)
                return string.Empty;
            
            var dst = build();
            
            for(var i = offset; i< src.Length; i++)
            {
                if(i!=offset)
                {
                    dst.Append(sep);
                    dst.Append(Chars.Space);
                }
                dst.Append(src[i].Format());
            }
            return dst.ToString();
        }

        /// <summary>
        /// Formats a sequence of formattable things as delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter, if specified; otherwise, a system default is chosen</param>
        /// <param name="offset">The index of the source element at which formatting will begin</param>
        /// <typeparam name="T">A formattable type</typeparam>
        public static string list<T>(IEnumerable<T> src, char? delimiter = null, int offset = 0)
            where T : ITextual
                => string.Join(delimiter ?? Chars.Comma, src.Skip(0).Select(x => x.Format()));                
    }
}