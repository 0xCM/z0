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
        public readonly struct Consequent : IRule<Consequent>
        {
            public TermId Id {get;}

            public dynamic Term {get;}

            [MethodImpl(Inline)]
            public Consequent(TermId id, dynamic src)
            {
                Id = id;
                Term = src;
            }

            [MethodImpl(Inline)]
            public bool Equals(Consequent src)
                => match(this, src);
        }
    }
}