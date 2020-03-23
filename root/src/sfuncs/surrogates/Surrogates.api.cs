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

    public static partial class Surrogates
    {
        [MethodImpl(Inline)]
        public static Emitter<T> emitter<T>(Z0.Emitter<T> f, OpIdentity id, T t = default)
            => new Emitter<T>(f,id);    

        [MethodImpl(Inline)]
        public static UnaryOp<T> unary<T>(Z0.UnaryOp<T> f, OpIdentity id, T t = default)
            => new UnaryOp<T>(f,id);

        [MethodImpl(Inline)]
        public static BinaryOp<T> binary<T>(Z0.BinaryOp<T> f, OpIdentity id, T t = default)
            => new BinaryOp<T>(f,id);

        [MethodImpl(Inline)]
        public static TernaryOp<T> ternary<T>(Z0.TernaryOp<T> f, OpIdentity id, T t = default)
            => new TernaryOp<T>(f,id);

        [MethodImpl(Inline)]
        public static UnaryPredicate<T> predicate<T>(Z0.UnaryPredicate<T> f, OpIdentity id, T t = default)
            => new UnaryPredicate<T>(f,id);

        [MethodImpl(Inline)]
        public static BinaryPredicate<T> predicate<T>(Z0.BinaryPredicate<T> f, OpIdentity id, T t = default)
            => new BinaryPredicate<T>(f,id);

        [MethodImpl(Inline)]
        public static Emitter<T> emitter<T>(Z0.Emitter<T> f, string name, T t = default)
            => new Emitter<T>(f,name);    

        [MethodImpl(Inline)]
        public static UnaryOp<T> unary<T>(Z0.UnaryOp<T> f, string name, T t = default)
            => new UnaryOp<T>(f,name);

        [MethodImpl(Inline)]
        public static BinaryOp<T> binary<T>(Z0.BinaryOp<T> f, string name, T t = default)
            => new BinaryOp<T>(f,name);

        [MethodImpl(Inline)]
        public static TernaryOp<T> ternary<T>(Z0.TernaryOp<T> f, string name, T t = default)
            => new TernaryOp<T>(f,name);

        [MethodImpl(Inline)]
        public static UnaryPredicate<T> predicate<T>(Z0.UnaryPredicate<T> f, string name, T t = default)
            => new UnaryPredicate<T>(f,name);

        [MethodImpl(Inline)]
        public static BinaryPredicate<T> predicate<T>(Z0.BinaryPredicate<T> f, string name, T t = default)
            => new BinaryPredicate<T>(f,name);
    }
}