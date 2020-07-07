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
    public readonly struct Delegated
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static System.Func<T> func<T>(Emitter<T> f)
            => new System.Func<T>(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static System.Func<T,T> func<T>(Z0.UnaryOp<T> f)
            => new System.Func<T,T>(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static System.Func<T,T,T> func<T>(BinaryOp<T> f)
            => new System.Func<T,T,T>(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static System.Func<T,T,T,T> func<T>(Z0.TernaryOp<T> f)
            => new System.Func<T,T,T,T>(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Emitter<T> emitter<T>(System.Func<T> f)
            => new Emitter<T>(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static UnaryOp<T> @operator<T>(System.Func<T,T> f)
            => new UnaryOp<T>(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BinaryOp<T> @operator<T>(System.Func<T,T,T> f)
            => new BinaryOp<T>(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static TernaryOp<T> @operator<T>(System.Func<T,T,T,T> f)
            => new TernaryOp<T>(f);

        [MethodImpl(Inline)]
        public static System.Func<T> func<T,C>(Emitter<T,C> f)
            where T : unmanaged
            where C : unmanaged
                => new System.Func<T>(f);

        [MethodImpl(Inline)]
        public static Emitter<T,C> emitter<T,C>(System.Func<T> f)
            where T : unmanaged
            where C : unmanaged
                => new Emitter<T,C>(f);


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