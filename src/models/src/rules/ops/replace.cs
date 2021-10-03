//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Functions;

    partial struct Rules
    {
        [Op]
        public static unsafe string apply(Replace<char> rule, string src)
        {
            var count = src.Length;
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

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Replace<T> replace<T>(T src, T dst)
            => new Replace<T>(src,dst);

        [Op, Closures(Closure)]
        public static Span<Replace<T>> replace<T>(Span<T> src, T dst)
        {
            var count = src.Length;
            var buffer = sys.alloc<Replace<T>>(count);
            ref var target = ref first(buffer);
            ref readonly var input = ref first(src);
            for(var i=0; i<count; i++)
                seek(target,i) = replace(skip(input,i), dst);
            return buffer;
        }

        /// <summary>
        /// Transforms a bijection into a sequence of replacement rules
        /// </summary>
        /// <param name="spec"></param>
        /// <typeparam name="T"></typeparam>
        [Op, Closures(Closure)]
        public static Span<Replace<T>> replace<T>(in BijectivePoints<T> spec)
        {
            var src = spec.Source;
            var dst = spec.Target;
            var count = src.Length;
            var buffer = alloc<Replace<T>>(count);
            ref var target = ref first(buffer);
            ref readonly var input = ref src.First;
            ref readonly var output = ref dst.First;
            for(var i=0; i<count; i++)
                seek(target,i) = replace(skip(input,i), skip(output,i));
            return buffer;
        }

        [Op, Closures(Closure)]
        public static Span<Replace<T>> replace<T>(Index<T> src, Index<T> dst)
            => replace(bijection<T>(src,dst));
    }
}