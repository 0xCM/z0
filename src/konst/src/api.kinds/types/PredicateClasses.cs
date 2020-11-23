//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using K = ApiPredicateKind;

    partial class Kinds
    {
        public readonly struct PredicateClass : IOperationalClassHost<PredicateClass,K> { public K Kind => K.Predicate; }

        public readonly struct UnaryPredicate : IOperationalClassHost<UnaryPredicate,K> { public K Kind => K.UnaryPredicate; }

        public readonly struct BinaryPredicate : IOperationalClassHost<BinaryPredicate,K> { public K Kind => K.BinaryPredicate; }

        public readonly struct TernaryPredicate : IOperationalClassHost<TernaryPredicate,K> { public K Kind => K.TernaryPredicate; }

        //~ Parametric
        //~ -------------------------------------------------------------------
        public readonly struct PredicateClass<T> : IOperationalClass<PredicateClass,K,T> {}

        public readonly struct UnaryPredicate<T> : IOperationalClass<UnaryPredicate,K,T> {}

        public readonly struct BinaryPredicate<T> : IOperationalClass<BinaryPredicate,K,T> {}

        public readonly struct TernaryPredicate<T> : IOperationalClass<TernaryPredicate,K,T> {}
    }
}