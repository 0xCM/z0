//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Components;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static Emitter<T> ToEmitter<T>(this System.Func<T> f)
            => new Emitter<T>(f);

        [MethodImpl(Inline)]
        public static Emitter<T,C> ToEmitter<T,C>(this System.Func<T> f)
            where T : unmanaged
            where C : unmanaged
                => new Emitter<T,C>(f);

        [MethodImpl(Inline)]
        public static UnaryOp<T> ToUnaryOp<T>(this System.Func<T,T> f)
            => new UnaryOp<T>(f);

        [MethodImpl(Inline)]
        public static BinaryOp<T> ToBinaryOp<T>(this System.Func<T,T,T> f)
            => new BinaryOp<T>(f);

        [MethodImpl(Inline)]
        public static TernaryOp<T> ToTernaryOp<T>(this System.Func<T,T,T,T> f)
            => new TernaryOp<T>(f);


        [MethodImpl(Inline)]
        public static System.Func<T> ToFunc<T>(this Emitter<T> f)
            => new System.Func<T>(f);

        [MethodImpl(Inline)]
        public static System.Func<T> ToFunc<T,C>(this Emitter<T,C> f)
            where T : unmanaged
            where C : unmanaged
                => new System.Func<T>(f);

        [MethodImpl(Inline)]
        public static System.Func<T,T> ToFunc<T>(this Z0.UnaryOp<T> f)
            => new System.Func<T,T>(f);

        [MethodImpl(Inline)]
        public static System.Func<T,T,T> ToFunc<T>(this BinaryOp<T> f)
            => new System.Func<T,T,T>(f);

        [MethodImpl(Inline)]
        public static System.Func<T,T,T,T> ToFunc<T>(this Z0.TernaryOp<T> f)
            => new System.Func<T,T,T,T>(f);
    }
}