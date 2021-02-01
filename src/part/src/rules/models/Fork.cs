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
        public readonly struct Fork : IRule<Fork>
        {
            public dynamic Criterion {get;}

            [MethodImpl(Inline)]
            public Fork(dynamic c)
            {
                Criterion = c;
            }
        }

        /// <summary>
        /// Ordains that a value of unspecified type is partitioned into two disjoint pieces by a criterion <typeparamref name='C'/>
        /// </summary>
        public readonly struct Fork<C> : IRule<Fork<C>,C>
        {
            public C Criterion {get;}

            [MethodImpl(Inline)]
            public Fork(C criterion)
                => Criterion = criterion;

            [MethodImpl(Inline)]
            public static implicit operator Fork(Fork<C> src)
                => new Fork(src.Criterion);

            [MethodImpl(Inline)]
            public static implicit operator Fork<C>(C src)
                => new Fork<C>(src);
        }
    }
}