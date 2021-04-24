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
    using static memory;
    using static Rules;

    partial class text
    {
        [Op]
        public static unsafe string apply(Replace<char> rule, string src)
        {
            var count = text.length(src);
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

        /// <summary>
        /// Creates a hashset from an input sequence
        /// </summary>
        /// <param name="rule">The rule specification</param>
        /// <param name="src">The input sequence</param>
        [Op]
        public static HashSet<string> apply(Distinct<string> rule, ReadOnlySpan<string> src)
        {
            var count = src.Length;
            var dst = root.hashset<string>(count);
            for(var i=0; i<count; i++)
                dst.Add(skip(src,i));
            return dst;
        }

        /// <summary>
        /// Applies a specified rule to partition a source string into two disjoint pieces
        /// that exclude the branch criterion character.
        /// </summary>
        /// <param name="rule">The transformation rule</param>
        /// <param name="src">The source string</param>
        [Op]
        public static Pair<string> apply(Fork<char> rule, string src)
            => root.pair(text.before(src, rule.Criterion), text.after(src, rule.Criterion));
    }
}