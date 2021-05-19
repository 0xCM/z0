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

    partial struct Rules
    {
        /// <summary>
        /// Applies a <see cref='Adjacent{T}'/> rule to a sequence of <typeparamref name='T'/> cells and
        /// deposits the indices of matched evaluations into a call-supplied target
        /// </summary>
        /// <param name="rule"></param>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns>The count of positive evaluations</returns>
        [Op, Closures(Closure)]
        public static uint adjacencies<T>(Adjacent<T> rule, ReadOnlySpan<T> src, Span<uint> dst)
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
    }
}