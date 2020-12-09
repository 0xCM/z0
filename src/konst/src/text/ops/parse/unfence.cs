//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly partial struct TextRules
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
            public static string unfence(string src, char left, char right)
            {
                if(text.blank(src))
                    return EmptyString;

                if(!TextTest.fenced(src,left,right))
                    return src;

                var data = src.Trim();
                var length = data.Length;
                return data.Substring(1, length - 2);
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