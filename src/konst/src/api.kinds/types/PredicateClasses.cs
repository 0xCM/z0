//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using K = ApiPredicateClass;

    partial class Kinds
    {
        public readonly struct PredicateClass : IOperationalF<PredicateClass,K> { public K Kind => K.Predicate; }

        public readonly struct UnaryPredicate : IOperationalF<UnaryPredicate,K> { public K Kind => K.UnaryPredicate; }

        public readonly struct BinaryPredicate : IOperationalF<BinaryPredicate,K> { public K Kind => K.BinaryPredicate; }

        public readonly struct TernaryPredicate : IOperationalF<TernaryPredicate,K> { public K Kind => K.TernaryPredicate; }

        //~ Parametric
        //~ -------------------------------------------------------------------
        public readonly struct PredicateClass<T> : IOperational<PredicateClass,K,T> {}

        public readonly struct UnaryPredicate<T> : IOperational<UnaryPredicate,K,T> {}

        public readonly struct BinaryPredicate<T> : IOperational<BinaryPredicate,K,T> {}

        public readonly struct TernaryPredicate<T> : IOperational<TernaryPredicate,K,T> {}
    }
}