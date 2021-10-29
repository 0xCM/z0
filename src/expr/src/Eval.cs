//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Eval
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using Z0.Rules;

    public readonly partial struct eval
    {
        const NumericKind Closure = UnsignedInts;

        public static uint apply<S,T>(ReadOnlySpan<S> src, Span<T> dst, IEvaluator<S,T> f)
        {
            var count = min(src.Length, dst.Length);
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                if(f.Eval(skip(src,i), out seek(dst,i)))
                    counter++;
                else
                    break;
            }
            return counter;
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
    }
}