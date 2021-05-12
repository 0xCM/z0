//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static TextRules;

    partial struct TextQuery
    {
        /// <summary>
        /// Determines whether a specified <see cref='string'/> ends with a specified <see cref='string'/>
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="match">The match text</param>
        [Op]
        public static bit tail(string src, string match)
        {
            if(text.nonempty(src) && text.nonempty(match))
                return src.EndsWith(match, InvariantCulture);
            return false;
        }

        /// <summary>
        /// Determines whether a specified <see cref='string'/> begins with a specified <see cref='char'/>
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="match">The match text</param>
        [Op]
        public unsafe static bit tail(string src, char match)
        {
            var len = text.length(src);
            if(len != 0)
                return src[len - 1] == match;
            else
                return false;
        }
    }
}