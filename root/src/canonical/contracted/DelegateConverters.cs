//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    
    using static Root;

    public static class DelegateConverters
    {
        [MethodImpl(Inline)]
        public static Z0.Emitter<T> ToEmitter<T>(this System.Func<T> f)
            => new Z0.Emitter<T>(f);

        [MethodImpl(Inline)]
        public static System.Func<T> ToFunc<T>(this Z0.Emitter<T> f)
            => new System.Func<T>(f);

        [MethodImpl(Inline)]
        public static System.Func<T> ToFunc<T,C>(this Z0.Emitter<T,C> f)
            where T : unmanaged
            where C : unmanaged
                => new System.Func<T>(f);

        [MethodImpl(Inline)]
        public static Z0.Emitter<T,C> ToEmitter<T,C>(this System.Func<T> f)
            where T : unmanaged
            where C : unmanaged
                => new Z0.Emitter<T,C>(f);

        [MethodImpl(Inline)]
        public static Z0.UnaryOp<T> ToUnaryOp<T>(this System.Func<T,T> f)
            => new Z0.UnaryOp<T>(f);

        [MethodImpl(Inline)]
        public static System.Func<T,T> ToFunc<T>(this Z0.UnaryOp<T> f)
            => new System.Func<T,T>(f);

        [MethodImpl(Inline)]
        public static Z0.BinaryOp<T> ToBinaryOp<T>(this System.Func<T,T,T> f)
            => new Z0.BinaryOp<T>(f);

        [MethodImpl(Inline)]
        public static System.Func<T,T,T> ToFunc<T>(this Z0.BinaryOp<T> f)
            => new System.Func<T,T,T>(f);

        [MethodImpl(Inline)]
        public static Z0.TernaryOp<T> ToTernaryOp<T>(this System.Func<T,T,T,T> f)
            => new Z0.TernaryOp<T>(f);

        [MethodImpl(Inline)]
        public static System.Func<T,T,T,T> ToFunc<T>(this Z0.TernaryOp<T> f)
            => new System.Func<T,T,T,T>(f);

        [MethodImpl(Inline)]
        public static Z0.UnaryPredicate<T> ToUnaryPredicate<T>(this System.Func<T,bit> f)
            => new Z0.UnaryPredicate<T>(f);

        [MethodImpl(Inline)]
        public static Z0.BinaryPredicate<T> ToBinaryPredicate<T>(this System.Func<T,T,bit> f)
            => new Z0.BinaryPredicate<T>(f);

        [MethodImpl(Inline)]
        public static System.Func<T,bit> ToFunc<T>(this Z0.UnaryPredicate<T> f)
            => new System.Func<T,bit>(f);
    }
}