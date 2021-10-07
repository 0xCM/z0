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
        /// Specifies that an element occurs at least once
        /// </summary>
        public readonly struct OneOrMany
        {
            public Index<dynamic> Elements {get;}

            [MethodImpl(Inline)]
            public OneOrMany(Index<dynamic> src)
                => Elements = src;

            public static Marker<string> Indicator => "(1..*)";
        }
    }
}