//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class DXTend
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static System.Func<T,T,bit> ToFunc<T>(this BinaryPredicate<T> f)
            => Delegates.func(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static System.Func<T,T,T> ToFunc<T>(this BinaryOp<T> f)
            => Delegates.func(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static System.Func<T,T,T,T> ToFunc<T>(this Z0.TernaryOp<T> f)
            => Delegates.func(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static System.Func<T,T> ToFunc<T>(this Z0.UnaryOp<T> f)
            => Delegates.func(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static System.Func<T> ToFunc<T>(this Emitter<T> f)
            => Delegates.func(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static System.Func<T,bit> ToFunc<T>(this UnaryPredicate<T> f)
            => Delegates.func(f);

        [MethodImpl(Inline)]
        public static System.Func<T> ToFunc<T,C>(this Emitter<T,C> f)
            where T : unmanaged
            where C : unmanaged
                => Delegates.func(f);
    }
}