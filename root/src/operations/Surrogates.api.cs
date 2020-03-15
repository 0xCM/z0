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
        public static Emitter<T,C> emitter<T,C>(Z0.Emitter<T> f, OpIdentity id, T t = default)
            where T : unmanaged
            where C : unmanaged
                => new Emitter<T,C>(f,id);    

        [MethodImpl(Inline)]
        public static Emitter<T,C> emitter<T,C>(Z0.Emitter<T,C> f, OpIdentity id, T t = default)
            where T : unmanaged
            where C : unmanaged
                => new Emitter<T,C>(f,id);    

        [MethodImpl(Inline)]
        public static UnaryOp<T> unaryop<T>(Z0.UnaryOp<T> f, OpIdentity id, T t = default)
            => new UnaryOp<T>(f,id);

        [MethodImpl(Inline)]
        public static BinaryOp<T> binaryop<T>(Z0.BinaryOp<T> f, OpIdentity id, T t = default)
            => new BinaryOp<T>(f,id);

        [MethodImpl(Inline)]
        public static UnaryPredicate<T> predicate<T>(Z0.UnaryPredicate<T> f, OpIdentity id, T t = default)
            => new UnaryPredicate<T>(f,id);
    }
}