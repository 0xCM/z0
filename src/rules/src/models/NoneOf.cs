//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RuleModels
    {
        /// <summary>
        /// Specifies that the occurence of an element is distinguished by non-membership in a specified set
        /// </summary>
        public readonly struct NoneOf<T>
        {
            public Index<T> Elements {get;}

            [MethodImpl(Inline)]
            public NoneOf(Index<T> choices)
            {
                Elements = choices;
            }

            [MethodImpl(Inline)]
            public static implicit operator NoneOf<T>(T[] src)
                => new NoneOf<T>(src);
        }
    }
}