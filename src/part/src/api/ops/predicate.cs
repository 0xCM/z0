//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static ApiClasses;

    partial struct Api
    {
        [KindFactory]
        public static UnaryPredicate predicate(A1 rep)
            => default;

        [KindFactory]
        public static BinaryPredicate predicate(A2 rep)
            => default;

        [KindFactory]
        public static TernaryPredicate predicate(A3 rep)
            => default;

        [KindFactory, Closures(Closure)]
        public static PredicateClass<T> predicate<T>()
            where T : unmanaged => default;

        [KindFactory, Closures(Closure)]
        public static UnaryPredicate<T> predicate<T>(A1<T> rep)
            where T : unmanaged => default;

        [KindFactory, Closures(Closure)]
        public static BinaryPredicate<T> predicate<T>(A2<T> rep)
            where T : unmanaged => default;

        [KindFactory, Closures(Closure)]
        public static TernaryPredicate<T> predicate<T>(A3<T> rep)
            where T : unmanaged => default;
    }
}