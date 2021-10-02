//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RuleModels
    {
        /// <summary>
        /// Disjunction
        /// </summary>
        public readonly struct Or
        {
            public Index<dynamic> Elements {get;}

            [MethodImpl(Inline)]
            public Or(Index<dynamic> src)
            {
                Elements = src;
            }
        }
    }
}