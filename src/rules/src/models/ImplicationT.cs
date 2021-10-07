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
        public readonly struct Implication<A,C>
            where A : IEquatable<A>
            where C : IEquatable<C>
        {
            public A Antecedant {get;}

            public C Consequent {get;}

            [MethodImpl(Inline)]
            public Implication(A a, C c)
            {
                Antecedant = a;
                Consequent = c;
            }

            [MethodImpl(Inline)]
            public static implicit operator Implication(Implication<A,C> src)
                => new Implication(src.Antecedant, src.Consequent);
        }
    }
}