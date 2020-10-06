//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using S = Surrogates;

    partial struct SFx
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static S.Func<T,T,bool> surrogate<T>(S.BinaryPredicate8<T> src)
            => new S.Func<T,T,bool>(Delegates.func(src.Subject), src.Id);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static S.Func<T> surrogate<T>(S.Emitter<T> src)
            => new S.Func<T>(Delegates.func(src.Subject), src.Id);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static S.Func<T,T> surrogate<T>(S.UnaryOp<T> src)
            => new S.Func<T,T>(Delegates.func(src.Subject), src.Id);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static S.Func<T,T,T> surrogate<T>(S.BinaryOp<T> src)
            => new S.Func<T,T,T>(Delegates.func(src.Subject), src.Id);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static S.Func<T,T,T,T> surrogate<T>(S.TernaryOp<T> src)
            => new S.Func<T,T,T,T>(Delegates.func(src.Subject), src.Id);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static S.Func<T,Bit32> surrogate<T>(S.UnaryPredicate<T> src)
            => new S.Func<T,Bit32>(Delegates.func(src.Subject), src.Id);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static S.Func<T,T,Bit32> surrogate<T>(S.BinaryPredicate<T> src)
            => new S.Func<T,T,Bit32>(Delegates.func(src.Subject), src.Id);
    }
}