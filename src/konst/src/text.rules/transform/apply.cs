//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static Rules;

    partial struct TextRules
    {
        partial struct Transform
        {
            public static unsafe string apply(Replacement<char> rule, string src)
            {
                var count = Query.length(src);
                var dst = span<char>(count);
                var input = span(src);
                apply(rule,src,dst);
                return new string(dst);
            }

            [MethodImpl(Inline), Op]
            public static unsafe void apply(Replacement<char> rule, ReadOnlySpan<char> src, Span<char> dst, int offset = 0)
            {
                var count = src.Length;
                var input = span(src);
                fixed(char* c = src)
                    for(var i=offset; i<count; i++)
                        seek(dst,i) = *c == rule.Match ? rule.Replace : skip(input,i);
            }
        }
    }
}