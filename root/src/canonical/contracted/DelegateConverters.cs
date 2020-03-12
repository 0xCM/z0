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
        public static Emitter<T> ToEmitter<T>(this Func<T> f)
            => new Emitter<T>(f);

        [MethodImpl(Inline)]
        public static UnaryOp<T> ToUnaryOp<T>(this Func<T,T> f)
            => new UnaryOp<T>(f);

        [MethodImpl(Inline)]
        public static BinaryOp<T> ToBinaryOp<T>(this Func<T,T,T> f)
            => new BinaryOp<T>(f);

        [MethodImpl(Inline)]
        public static TernaryOp<T> ToTernaryOp<T>(this Func<T,T,T,T> f)
            => new TernaryOp<T>(f);

        [MethodImpl(Inline)]
        public static UnaryPredicate<T> ToUnaryPredicate<T>(this Func<T,bit> f)
            => new UnaryPredicate<T>(f);
    }
}