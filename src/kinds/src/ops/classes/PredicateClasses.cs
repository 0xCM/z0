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
        public readonly struct PredicateClass : IOpClassF<PredicateClass,K> 
        { 
            public K Class => K.Predicate; 
        }

        public readonly struct UnaryPredicate : IOpClassF<UnaryPredicate,K> 
        {
             public K Class => K.UnaryPredicate; 
        }

        public readonly struct BinaryPredicate : IOpClassF<BinaryPredicate,K> 
        {
             public K Class => K.BinaryPredicate; 
        }

        public readonly struct TernaryPredicate : IOpClassF<TernaryPredicate,K> 
        { 
            public K Class => K.TernaryPredicate; 
        }

        public readonly struct PredicateClass<T> : IOpClassF<PredicateClass<T>,K,T> 
            where T : unmanaged 
        {
             public K Class => K.Predicate; 
        }

        public readonly struct UnaryPredicate<T> : IOpClassF<UnaryPredicate<T>,K,T> 
            where T : unmanaged 
        { 
            public K Class => K.UnaryPredicate; 
        }

        public readonly struct BinaryPredicate<T> : IOpClassF<BinaryPredicate<T>,K,T> 
            where T : unmanaged 
        { 
            public K Class => K.BinaryPredicate; 
        }

        public readonly struct TernaryPredicate<T> : IOpClassF<TernaryPredicate<T>,K,T> 
            where T : unmanaged 
        { 
            public K Class => K.TernaryPredicate; 
        }
    }
}