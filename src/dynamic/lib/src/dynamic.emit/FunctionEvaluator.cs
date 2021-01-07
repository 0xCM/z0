//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct FunctionEvaluator
    {
        [MethodImpl(Inline)]
        public static T eval<K,T>(K k, ReadOnlySpan<byte> code, T x, T y)
            where K : unmanaged, IApiKey
            where T : unmanaged
                => create(x, y, k.Format(), code)(x,y);

        [MethodImpl(Inline)]
        public static T eval<K,T>(K k, BinaryCode code, T x, T y)
            where T : unmanaged
            where K : unmanaged, IApiKey
                => create(x, y, k.Format(), code)(x,y);

        [MethodImpl(Inline)]
        public static T eval<T>(T x, T y, string name, ReadOnlySpan<byte> code)
            where T : unmanaged
                => create(x, y, name, code)(x,y);

        [MethodImpl(Inline)]
        public static T eval<T>(T x, T y, string name, BinaryCode code)
            where T : unmanaged
                => create(x, y, name, code)(x,y);

        [MethodImpl(Inline)]
        static BinaryOp<T>  create<T>(T x, T y, string name, ReadOnlySpan<byte> f)
            where T : unmanaged
                => BinaryOpFactory.create<T>(name, new BinaryCode(f.ToArray()));

        [MethodImpl(Inline)]
        static BinaryOp<T> create<T>(T x, T y, string name, BinaryCode f)
            where T : unmanaged
                => BinaryOpFactory.create<T>(name,f);
    }
}