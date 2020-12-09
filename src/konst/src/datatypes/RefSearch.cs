//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static Delegates;

    public struct RefSearch<T>
    {
        public readonly RefComparer<T> Fx;

        [MethodImpl(Inline)]
        public RefSearch(RefComparer<T> fx)
        {
            Fx = fx;
        }

        [MethodImpl(Inline)]
        int Search(ReadOnlySpan<T> src, in T match, ref int lower, ref int upper)
        {
            var mix = (lower + upper) >> 1;
            ref readonly var next = ref skip(src, mix);
            var result = Fx(next, match);
            if (result > 0)
                upper = mix - 1;
            else if (result < 0)
                lower = mix + 1;
            else
                return mix;

            return NotFound;
        }

        [MethodImpl(Inline)]
        public int Search(ReadOnlySpan<T> src, in T match)
        {
            var lower = 0;
            var upper = src.Length - 1;

            while (lower <= upper)
            {
                var mix = Search(src, match, ref lower, ref upper);
                if(mix != NotFound)
                    return mix;
            }

            return NotFound;
        }
    }
}