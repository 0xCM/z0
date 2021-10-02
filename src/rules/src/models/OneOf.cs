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
        /// Specifies that the occurence of an element is distinguished by membership in a specified set
        /// </summary>
        public readonly struct OneOf : IRule<OneOf>
        {
            public Index<dynamic> Elements {get;}

            [MethodImpl(Inline)]
            public OneOf(Index<dynamic> choices)
                => Elements = choices;

            public uint Count
            {
                [MethodImpl(Inline)]
                get => Elements.Count;
            }
        }
    }
}