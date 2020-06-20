//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct BinaryOpEvaluator
    {
        [MethodImpl(Inline)]
        public static T eval<K,T>(K k, ReadOnlySpan<byte> code, T x, T y)
            where K : unmanaged, IOpKind
            => BinaryOpEvaluator<T>.eval(x, y, k.Format(), code);

        [MethodImpl(Inline)]
        public static T eval<K,T>(IOpKind k, BinaryCode code, T x, T y)
            where K : unmanaged, IOpKind
                => BinaryOpEvaluator<T>.eval(x, y, k.Format(), code);

        [MethodImpl(Inline)]
        public static T eval<T>(T x, T y, string name, ReadOnlySpan<byte> code)
            => BinaryOpEvaluator<T>.eval(x, y, name, code);

        [MethodImpl(Inline)]
        public static T eval<T>(T x, T y, string name, BinaryCode code)
            => BinaryOpEvaluator<T>.eval(x, y, name, code);
    }

    readonly struct BinaryOpEvaluator<T>
    {
        [MethodImpl(Inline)]
        public static T eval(T x, T y, string name, ReadOnlySpan<byte> f)
            => BinaryOpEmitter.emit<T>(name, new BinaryCode(f.ToArray()))(x,y);

        [MethodImpl(Inline)]
        public static T eval(T x, T y, string name, BinaryCode f)
            => BinaryOpEmitter.emit<T>(name,f)(x,y);
    }
}