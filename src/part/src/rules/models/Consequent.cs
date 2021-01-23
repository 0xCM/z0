//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Rules
    {
        public readonly struct Consequent : IConsequent
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
                => equals(this, src);
        }

        public readonly struct Consequent<C> : IConsequent<C>
            where C : IEquatable<C>
        {
            public TermId Id {get;}

            public C Term {get;}

            [MethodImpl(Inline)]
            public Consequent(TermId id, C src)
            {
                Id = id;
                Term = src;
            }

            [MethodImpl(Inline)]
            public bool Equals(Consequent<C> src)
                => equals(this, src);

            [MethodImpl(Inline)]
            public static implicit operator Consequent(Consequent<C> src)
                => new Consequent(src.Id, src.Term);
        }
    }
}