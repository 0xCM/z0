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
    using static Rules;

    partial struct RuleCalcs
    {
        [Op, Closures(Closure)]
        public static Interspersal<T> apply<T>(Intersperse<T> rule, Index<T> src)
            => interspersed(src.Storage.Intersperse(rule.Element), rule);

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

    }
}