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
            [Op]
            public static unsafe string apply(Replace<char> rule, string src)
            {
                var count = Query.length(src);
                var dst = span<char>(count);
                var input = span(src);
                apply(rule, src, dst);
                return new string(dst);
            }

            /// <summary>
            /// Replaces source characters that satisfy a specified replacement rule with the rule-specified replacement
            /// </summary>
            /// <param name="rule"></param>
            /// <param name="src"></param>
            /// <param name="dst"></param>
            /// <param name="offset"></param>
            [Op]
            public static unsafe void apply(Replace<char> rule, ReadOnlySpan<char> src, Span<char> dst, int offset = 0)
            {
                var count = src.Length;
                for(var i=offset; i<count; i++)
                {
                    ref readonly var c = ref skip(src,i);
                    seek(dst,i) = c == rule.Match ? rule.With : c;
                }
            }

            /// <summary>
            /// Replaces source characters in-place that satisfy a specified replacement rule with the rule-specified replacement
            /// </summary>
            /// <param name="rule">The replacement rule</param>
            /// <param name="io">The source and the target</param>
            /// <param name="offset">The offset at which to begin</param>
            [Op]
            public static unsafe void apply(Replace<char> rule, Span<char> io, int offset = 0)
            {
                var count = io.Length;
                for(var i=offset; i<count; i++)
                {
                    ref readonly var c = ref skip(io,i);
                    seek(io,i) = c == rule.Match ? rule.With : c;
                }
            }
        }
    }
}