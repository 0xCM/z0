//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    
    using K = PredicateClassKind;

    partial class Kinds
    {
        public readonly struct PredicateClass : IOpClassF<PredicateClass,K> { public K Kind => K.Predicate; }

        public readonly struct UnaryPredicate : IOpClassF<UnaryPredicate,K> { public K Kind => K.UnaryPredicate; }

        public readonly struct BinaryPredicate : IOpClassF<BinaryPredicate,K> { public K Kind => K.BinaryPredicate; }

        public readonly struct TernaryPredicate : IOpClassF<TernaryPredicate,K> { public K Kind => K.TernaryPredicate; }


        //~ Parametric
        //~ -------------------------------------------------------------------
        public readonly struct PredicateClass<T> : IOpClass<PredicateClass,K,T> {}

        public readonly struct UnaryPredicate<T> : IOpClass<UnaryPredicate,K,T> {}

        public readonly struct BinaryPredicate<T> : IOpClass<BinaryPredicate,K,T> {}

        public readonly struct TernaryPredicate<T> : IOpClass<TernaryPredicate,K,T> {}
    }
}