//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K = PredicateClass;

    partial class Kinds
    {
        public readonly struct PredicateClass<T> : IOpClass<PredicateClass,K,T> {}

        public readonly struct UnaryPredicate<T> : IOpClass<UnaryPredicate,K,T> {}

        public readonly struct BinaryPredicate<T> : IOpClass<BinaryPredicate,K,T> {}

        public readonly struct TernaryPredicate<T> : IOpClass<TernaryPredicate,K,T> {}
    }
}