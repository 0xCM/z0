//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    partial struct TextFormatter
    {
        /// <summary>
        /// Concatenates a sequence of characters with no intervening delimiter
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        [MethodImpl(Inline), Op]
        public static string concat(IEnumerable<char> src)
            => string.Concat(src);

        [Op]
        public static string concat(ReadOnlySpan<string> src, char? delimiter)
        {
            var dst = text.build();
            for(var i=0; i<src.Length; i++)
            {
                if(i != 0 && delimiter != null)
                    dst.Append(delimiter.Value);
                dst.Append(src[i]);
            }
            return dst.ToString();
        }

        [Op]
        public static string concat(ReadOnlySpan<string> src, string delimiter)
        {
            var dst = text.build();
            for(var i=0; i<src.Length; i++)
            {
                if(i != 0 && delimiter != null)
                    dst.Append(delimiter);
                dst.Append(src[i]);
            }
            return dst.ToString();
        }
    }
}