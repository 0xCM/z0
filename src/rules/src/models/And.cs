//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        /// <summary>
        /// Conjunction
        /// </summary>
        public readonly struct And : IRule<And>
        {
            public Index<dynamic> Elements {get;}

            [MethodImpl(Inline)]
            public And(Index<dynamic> src)
            {
                Elements = src;
            }
        }
    }
}