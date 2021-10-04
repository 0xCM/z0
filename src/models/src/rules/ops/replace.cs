//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Models.Functions;

    partial struct Rules
    {
        /// <summary>
        /// Replaces source characters that satisfy a specified replacement rule with the rule-specified replacement
        /// </summary>
        /// <param name="rule"></param>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <param name="offset"></param>
        [Op]
        public static unsafe void apply<T>(Replace<T> rule, ReadOnlySpan<T> src, Span<T> dst, int offset = 0)
        {
            var count = src.Length;
            for(var i=offset; i<count; i++)
            {
                ref readonly var c = ref skip(src,i);
                seek(dst,i) = c.Equals(rule.Match) ? rule.Value : c;
            }
        }

        [Op, Closures(Closure)]
        public static uint apply<T>(Adjacent<T> rule, ReadOnlySpan<T> src, Span<uint> dst)
            where T : unmanaged, IEquatable<T>
        {
            var terms = Math.Min(src.Length - 1, dst.Length);
            var matched = 0u;
            for(var i=0u; i<terms; i++)
            {
                ref readonly var s0 = ref skip(src, i);
                ref readonly var s1 = ref skip(src, i + 1);
                if((s0.Equals(rule.A) && s1.Equals(rule.B)))
                    seek(dst, matched++) = i;
            }
            return matched;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Replace<T> replace<T>(T src, T dst)
            where T : IEquatable<T>
                => new Replace<T>(src,dst);

        [Op, Closures(Closure)]
        public static Span<Replace<T>> replacements<T>(Span<T> src, T dst)
            where T : IEquatable<T>
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
        public static Span<Replace<T>> replacements<T>(in BijectivePoints<T> spec)
            where T : IEquatable<T>
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
        public static Span<Replace<T>> replacements<T>(Index<T> src, Index<T> dst)
            where T : IEquatable<T>
                => replacements(bijection<T>(src,dst));
    }
}