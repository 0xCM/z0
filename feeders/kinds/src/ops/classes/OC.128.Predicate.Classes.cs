//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using C = PredicateClass;

    partial class OpClass
    {
        public readonly struct PredicateClass : IOpClassF<PredicateClass,C> 
        { 
            public C Class => C.Predicate; 
        }

        public readonly struct UnaryPredicate : IOpClassF<UnaryPredicate,C> 
        {
             public C Class => C.UnaryPredicate; 
        }

        public readonly struct BinaryPredicate : IOpClassF<BinaryPredicate,C> 
        {
             public C Class => C.BinaryPredicate; 
        }

        public readonly struct TernaryPredicate : IOpClassF<TernaryPredicate,C> 
        { 
            public C Class => C.TernaryPredicate; 
        }

        public readonly struct PredicateClass<T> : IOpClassF<PredicateClass<T>,C,T> 
            where T : unmanaged 
        {
             public C Class => C.Predicate; 
        }

        public readonly struct UnaryPredicate<T> : IOpClassF<UnaryPredicate<T>,C,T> 
            where T : unmanaged 
        { 
            public C Class => C.UnaryPredicate; 
        }

        public readonly struct BinaryPredicate<T> : IOpClassF<BinaryPredicate<T>,C,T> 
            where T : unmanaged 
        { 
            public C Class => C.BinaryPredicate; 
        }

        public readonly struct TernaryPredicate<T> : IOpClassF<TernaryPredicate<T>,C,T> 
            where T : unmanaged 
        { 
            public C Class => C.TernaryPredicate; 
        }
    }
}