//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Rules;
    using static memory;

    partial struct TextRules
    {
        partial struct Query
        {
            /// <summary>
            /// Determines whether a specified <see cref='string'/> ends with a specified <see cref='string'/>
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="match">The match text</param>
            [Op]
            public static bool tail(string src, string match)
            {
                if(nonempty(src) && nonempty(match))
                    return src.EndsWith(match, InvariantCulture);
                return false;
            }

            /// <summary>
            /// Determines whether a specified <see cref='string'/> begins with a specified <see cref='char'/>
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="match">The match text</param>
            [Op]
            public unsafe static bool tail(string src, char match)
            {
                var len = length(src);
                if(len != 0)
                    return src[len - 1] == match;
                else
                    return false;
            }
        }
    }
}