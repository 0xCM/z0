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

    partial class Surrogates
    {
        [MethodImpl(Inline)]
        public static Func<T> ToFunc<T>(this Emitter<T> src)
            => new Func<T>(src.Surrogated.ToFunc(), src.Id);

        [MethodImpl(Inline)]
        public static Emitter<T> ToEmitter<T>(this Func<T> src)
            => emitter(src.Surrogated.ToEmitter(), src.Id);

        [MethodImpl(Inline)]
        public static Func<T> ToFunc<T,C>(this Emitter<T,C> src)
            where T : unmanaged
            where C : unmanaged
                => new Func<T>(src.Surrogated.ToFunc(), src.Id);

        [MethodImpl(Inline)]
        public static Emitter<T,C> ToEmitter<T,C>(this Func<T> src, C cell = default)
            where T : unmanaged
            where C : unmanaged
                => new Emitter<T,C>(src.Surrogated.ToEmitter(), src.Id);

        [MethodImpl(Inline)]
        public static Func<T,T> ToFunc<T>(this UnaryOp<T> src)
            => new Func<T,T>(src.Surrogated.ToFunc(), src.Id);

        [MethodImpl(Inline)]
        public static UnaryOp<T> ToUnaryOp<T>(this Func<T,T> src)
            => unaryop(src.Surrogated.ToUnaryOp(), src.Id);

        [MethodImpl(Inline)]
        public static Func<T,T,T> ToFunc<T>(this BinaryOp<T> src)
            => new Func<T,T,T>(src.Surrogated.ToFunc(), src.Id);

        [MethodImpl(Inline)]
        public static BinaryOp<T> ToBinaryOp<T>(this Func<T,T,T> src)
            => binaryop(src.Surrogated.ToBinaryOp(), src.Id);

        [MethodImpl(Inline)]
        public static Func<T,bit> ToFunc<T>(this UnaryPredicate<T> src)
            => new Func<T,bit>(src.Surrogated.ToFunc(), src.Id);
    }
}