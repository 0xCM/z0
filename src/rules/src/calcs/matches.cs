//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Rules;

    partial struct RuleCalcs
    {
        [MethodImpl(Inline)]
        public static bool matches<S,T>(SubSeq<S,T> rule, S src)
            where S : IEquatable<S>
                => src.Equals(rule.Source);

        /// <summary>
        /// Extracts a subsequence, if it exists
        /// </summary>
        /// <param name="rule">The search specification</param>
        /// <param name="src">The sequence to search</param>
        /// <param name="dst">The subsequence, if found</param>
        /// <typeparam name="S">The sequence aggregate type</typeparam>
        /// <typeparam name="T">The sequence element type</typeparam>
        [MethodImpl(Inline)]
        public static Outcome match<S,T>(SubSeq<S,T> rule, S src, out Index<T> dst)
            where S : IEquatable<S>
        {
            if(matches(rule,src))
            {
                dst = rule.Target;
                return true;
            }
            else
            {
                dst = Index<T>.Empty;
                return false;
            }
        }
    }
}