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
        public interface IImplication : ITerm
        {

        }

        public interface IImplication<I,A,C> : IImplication
            where I : unmanaged, IEquatable<I>
            where A : IEquatable<A>
            where C : IEquatable<C>
        {
            I Index {get;}

            A Antecedant {get;}

            C Consequent {get;}

            TermId ITerm.Id
                => memory.u32(Index);
        }

        /// <summary>
        /// Specifies an if->then style rule as described by https://en.wikipedia.org/wiki/Material_conditional
        /// </summary>
        public readonly struct Implication<I,A,C> : IImplication<I,A,C>
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
        }
    }
}