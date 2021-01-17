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

    partial struct Rules
    {
        [Op, Closures(Closure)]
        public static uint adjacencies<T>(Adjacent<T> rule, ReadOnlySpan<T> src, Span<uint> dst)
            where T : unmanaged, IEquatable<T>
        {
            var terms = root.min(src.Length - 1, dst.Length);
            var matched = 0u;
            for(var i=0u; i<terms; i++)
            {
                ref readonly var s0 = ref skip(src, i);
                ref readonly var s1 = ref skip(src, i + 1);
                if((s0.Equals(rule.A) & s1.Equals(rule.B)))
                    seek(dst, matched++) = i;
            }
            return matched;
        }

    }
}