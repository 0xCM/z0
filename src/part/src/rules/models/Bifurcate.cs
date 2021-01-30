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
        public readonly struct Bifurcate : IRule<Bifurcate>
        {
            public dynamic Criterion {get;}

            [MethodImpl(Inline)]
            public Bifurcate(dynamic c)
            {
                Criterion = c;
            }
        }

        /// <summary>
        /// Ordains that a value of unspecified type is partitioned into two disjoint pieces by a criterion <typeparamref name='C'/>
        /// </summary>
        public readonly struct Bifurcate<C> : IRule<Bifurcate<C>,C>
        {
            public C Criterion {get;}

            [MethodImpl(Inline)]
            public Bifurcate(C criterion)
            {
                Criterion = criterion;
            }

            [MethodImpl(Inline)]
            public static implicit operator Bifurcate(Bifurcate<C> src)
                => new Bifurcate(src.Criterion);

            [MethodImpl(Inline)]
            public static implicit operator Bifurcate<C>(C src)
                => new Bifurcate<C>(src);
        }
    }
}