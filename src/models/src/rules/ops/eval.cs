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
        /// Replaces source characters that satisfy a specified replacement rule with the rule-specified replacement
        /// </summary>
        /// <param name="rule"></param>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <param name="offset"></param>
        [Op]
        public static unsafe void eval<T>(Replace<T> rule, ReadOnlySpan<T> src, Span<T> dst, int offset = 0)
        {
            var count = src.Length;
            for(var i=offset; i<count; i++)
            {
                ref readonly var c = ref skip(src,i);
                seek(dst,i) = c.Equals(rule.Match) ? rule.Value : c;
            }
        }

        [MethodImpl(Inline)]
        public static CmpEval<T> eval<T>(CmpPred<T> pred, bit eval)
            => new CmpEval<T>(pred, eval);

    }
}