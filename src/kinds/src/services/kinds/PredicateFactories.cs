//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Kinds
    {
        public static UnaryPredicate predicate(A1 rep) 
            => default;

        public static BinaryPredicate predicate(A2 rep) 
            => default;

        public static TernaryPredicate predicate(A3 rep) 
            => default;

        public static PredicateClass<T> predicate<T>()  
            where T : unmanaged => default;   

        public static UnaryPredicate<T> predicate<T>(A1<T> rep)  
            where T : unmanaged => default;   

        public static BinaryPredicate<T> predicate<T>(A2<T> rep) 
            where T : unmanaged => default;

        public static TernaryPredicate<T> predicate<T>(A3<T> rep)  
            where T : unmanaged => default;    
    }
}