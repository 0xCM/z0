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
        public readonly struct PredicateClass : IOperationClass<C> { public C Class => C.Predicate; }

        public readonly struct UnaryPredicate : IOperationClass<C> { public C Class => C.UnaryPredicate; }

        public readonly struct BinaryPredicate : IOperationClass<C> { public C Class => C.BinaryPredicate; }

        public readonly struct TernaryPredicate : IOperationClass<C> { public C Class => C.TernaryPredicate; }

        public readonly struct PredicateClass<T> : IOperationClass<C,T> where T : unmanaged { public C Class => C.Predicate; }

        public readonly struct UnaryPredicate<T> : IOperationClass<C,T> where T : unmanaged { public C Class => C.UnaryPredicate; }

        public readonly struct BinaryPredicate<T> : IOperationClass<C,T> where T : unmanaged { public C Class => C.BinaryPredicate; }

        public readonly struct TernaryPredicate<T> : IOperationClass<C,T> where T : unmanaged { public C Class => C.TernaryPredicate; }
    }
}