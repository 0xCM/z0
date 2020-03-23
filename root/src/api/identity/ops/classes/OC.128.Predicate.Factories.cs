//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static OperationClasses;

    public static partial class OperationClassReps
    {
        public static PredicateClass Predicate => default;

        public static UnaryPredicate UnaryPredicate => default;

        public static BinaryPredicate BinaryPredicate => default;

        public static TernaryPredicate TernaryPredicate => default;

        public static PredicateClass predicate() => default;

        public static UnaryPredicate predicate(Unary rep) => default;

        public static BinaryPredicate predicate(Binary rep) => default;

        public static TernaryPredicate predicate(Ternary rep) => default;

        public static PredicateClass<T> predicate<T>()  where T : unmanaged => default;   

        public static UnaryPredicate<T> predicate<T>(Unary<T> rep)  where T : unmanaged => default;   

        public static BinaryPredicate<T> predicate<T>(Binary<T> rep) where T : unmanaged => default;

        public static TernaryPredicate<T> predicate<T>(Ternary<T> rep)  where T : unmanaged => default;    
    }
}