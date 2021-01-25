//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using K = PredicateClass;

    public readonly struct PredicateClasses
    {
        public readonly struct PredicateClass : IOperationClassHost<PredicateClass,K> { public K Kind => K.Predicate; }

        public readonly struct UnaryPredicate : IOperationClassHost<UnaryPredicate,K> { public K Kind => K.UnaryPredicate; }

        public readonly struct BinaryPredicate : IOperationClassHost<BinaryPredicate,K> { public K Kind => K.BinaryPredicate; }

        public readonly struct TernaryPredicate : IOperationClassHost<TernaryPredicate,K> { public K Kind => K.TernaryPredicate; }

        public readonly struct PredicateClass<T> : IOperationClass<PredicateClass,K,T> {}

        public readonly struct UnaryPredicate<T> : IOperationClass<UnaryPredicate,K,T> {}

        public readonly struct BinaryPredicate<T> : IOperationClass<BinaryPredicate,K,T> {}

        public readonly struct TernaryPredicate<T> : IOperationClass<TernaryPredicate,K,T> {}
    }
}