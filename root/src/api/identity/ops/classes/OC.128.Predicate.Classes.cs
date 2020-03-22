//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using C = PredicateClass;

    partial class Classes
    {
        public readonly struct PredicateClass : IOpClass<C> { public C Class => C.Predicate; }

        public readonly struct UnaryPredicate : IOpClass<C> { public C Class => C.UnaryPredicate; }

        public readonly struct BinaryPredicate : IOpClass<C> { public C Class => C.BinaryPredicate; }

        public readonly struct TernaryPredicate : IOpClass<C> { public C Class => C.TernaryPredicate; }

        public readonly struct PredicateClass<T> : IOpClass<C,T> where T : unmanaged { public C Class => C.Predicate; }

        public readonly struct UnaryPredicate<T> : IOpClass<C,T> where T : unmanaged { public C Class => C.UnaryPredicate; }

        public readonly struct BinaryPredicate<T> : IOpClass<C,T> where T : unmanaged { public C Class => C.BinaryPredicate; }

        public readonly struct TernaryPredicate<T> : IOpClass<C,T> where T : unmanaged { public C Class => C.TernaryPredicate; }
    }
}