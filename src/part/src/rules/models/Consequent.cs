//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Rules
    {
        public interface IConsequent : ITerm
        {

        }

        public interface IConsequent<C> : IConsequent, ITerm<C>
            where C : IEquatable<C>
        {
            C Term {get;}
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

            public bool Equals(Consequent<C> src)
                => equals(this, src);
        }
    }
}