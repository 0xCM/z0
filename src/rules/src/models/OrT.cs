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
        /// Disjunction
        /// </summary>
        public readonly struct Or<T>
        {
            public Index<T> Elements {get;}

            [MethodImpl(Inline)]
            public Or(Index<T> src)
            {
                Elements = src;
            }

            [MethodImpl(Inline)]
            public static implicit operator Or(Or<T> src)
                => new Or(src.Elements.Select(x => (dynamic)x));
        }
    }
}