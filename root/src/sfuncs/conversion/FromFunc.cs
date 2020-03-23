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
    using S = Surrogates;

    public static partial class OperationConverters
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
        public static UnaryPredicate<T> ToUnaryPredicate<T>(this System.Func<T,bit> f)
            => new UnaryPredicate<T>(f);

        [MethodImpl(Inline)]
        public static Z0.BinaryPredicate<T> ToBinaryPredicate<T>(this System.Func<T,T,bit> f)
            => new Z0.BinaryPredicate<T>(f);

        [MethodImpl(Inline)]
        public static S.Emitter<T> ToEmitter<T>(this S.Func<T> src)
            => S.emitter(src.Subject.ToEmitter(), src.Id);

        [MethodImpl(Inline)]
        public static S.UnaryOp<T> ToUnaryOp<T>(this S.Func<T,T> src)
            => S.unary(src.Subject.ToUnaryOp(), src.Id);

        [MethodImpl(Inline)]
        public static S.BinaryOp<T> ToBinaryOp<T>(this S.Func<T,T,T> src)
            => S.binary(src.Subject.ToBinaryOp(), src.Id);

        [MethodImpl(Inline)]
        public static S.TernaryOp<T> ToTernaryOp<T>(this S.Func<T,T,T,T> src)
            => S.ternary(src.Subject.ToTernaryOp(), src.Id);
    }
}