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

    partial struct TextRules
    {
        partial struct Parse
        {
            /// <summary>
            /// Extracts text that is enclosed between left and right boundaries, i.e. {left}{content}{right} => {content}
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="left">The left boundary</param>
            /// <param name="right">The right boundary</param>
            [Op]
            public static ParseResult<string> unfence(string src, char left, char right)
            {
                if(Query.blank(src))
                    return root.unparsed<string>(src);

                if(!Query.fenced(src,left,right))
                    return root.unparsed<string>(src);

                var data = src.Trim();
                return root.parsed(src, substring(data, 1, data.Length - 2));
            }

            /// <summary>
            /// Extracts text that is enclosed between left and right boundaries, i.e. {left}{content}{right} => {content}
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="left">The left boundary</param>
            /// <param name="right">The right boundary</param>
            [Op]
            public static bool unfence(string src, Fence<char> fence, out string dst)
            {
                dst = EmptyString;
                if(!Query.blank(src) && Query.fenced(src, fence.Left, fence.Right))
                {
                    var len = src.Length;
                    dst = substring(src.Trim(), 1, len - 2);
                    return true;
                }

                return false;
            }

            /// <summary>
            /// Extracts text that is enclosed between left and right boundaries, i.e. {left}{content}{right} => {content}
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="left">The left boundary</param>
            /// <param name="right">The right boundary</param>
            [Op]
            public static string unfence(string src, string left, string right)
            {
                (var i0, var i1) = indices(src, left, right);
                if(i0 != NotFound && i1 != NotFound &&(i0 < i1))
                {
                    var start = i0 + left.Length;
                    var length = i1 - start;
                    return slice(src, start, length);
                }

                return EmptyString;
            }
        }
    }
}