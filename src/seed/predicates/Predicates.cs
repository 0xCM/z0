//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct Predicates
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static System.Func<T,T,bit> func<T>(BinaryPredicate<T> f)
            => new System.Func<T,T,bit>(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static System.Func<T,bit> func<T>(UnaryPredicate<T> f)
            => new System.Func<T,bit>(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static UnaryPredicate<T> predicate<T>(System.Func<T,bit> f)
            => new UnaryPredicate<T>(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Z0.BinaryPredicate<T> predicate<T>(System.Func<T,T,bit> f)
            => new Z0.BinaryPredicate<T>(f);
    }
}