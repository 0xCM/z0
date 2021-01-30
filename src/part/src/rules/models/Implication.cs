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
        public readonly struct Implication : IRule<Implication>
        {
            public dynamic Antecedant {get;}

            public dynamic Consequent {get;}

            [MethodImpl(Inline)]
            public Implication(dynamic a, dynamic c)
            {
                Antecedant = a;
                Consequent = c;
            }
        }

        public readonly struct Implication<A,C> : IRule<Implication<A,C>,A,C>
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

        /// <summary>
        /// Specifies an if->then style rule as described by https://en.wikipedia.org/wiki/Material_conditional
        /// </summary>
        public readonly struct Implication<I,A,C> : IRule<Implication<I,A,C>,I,A,C>
            where I : unmanaged, IEquatable<I>
            where A : IEquatable<A>
            where C : IEquatable<C>
        {
            public I Index {get;}

            public A Antecedant {get;}

            public C Consequent {get;}

            [MethodImpl(Inline)]
            public Implication(I index, A a, C c)
            {
                Index = index;
                Antecedant = a;
                Consequent = c;
            }

            [MethodImpl(Inline)]
            public static implicit operator Implication<A,C>(Implication<I,A,C> src)
                => new Implication<A,C>(src.Antecedant, src.Consequent);
        }
    }
}