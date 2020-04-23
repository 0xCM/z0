//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K = PredicateClass;

    partial class OpClass
    {
        public readonly struct PredicateClass : IOpClassF<PredicateClass,K> { public K Class => K.Predicate; }

        public readonly struct UnaryPredicate : IOpClassF<UnaryPredicate,K> { public K Class => K.UnaryPredicate; }

        public readonly struct BinaryPredicate : IOpClassF<BinaryPredicate,K> { public K Class => K.BinaryPredicate; }

        public readonly struct TernaryPredicate : IOpClassF<TernaryPredicate,K> { public K Class => K.TernaryPredicate; }

    }
}