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
        /// Represents the logical negation of a distinguished subject
        /// </summary>
        public readonly struct Not : IRule<Not>
        {
            public dynamic Element {get;}

            [MethodImpl(Inline)]
            public Not(dynamic src)
                => Element = src;
        }
    }
}