//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct FunctionEvaluator
    {
        [MethodImpl(Inline)]
        public static T eval<K,T>(K k, ReadOnlySpan<byte> code, T x, T y)
            where K : unmanaged, IApiClass
            where T : unmanaged
        {
            var name = BinaryOpFactory.identify<K,T>(k, false);
            var fx = BinaryOpFactory.create<T>(name, code);
            return fx(x,y);
        }

        [MethodImpl(Inline)]
        public static T eval<T>(T x, T y, Identifier name, ReadOnlySpan<byte> code)
            where T : unmanaged
        {
            var fx = BinaryOpFactory.create<T>(name, code);
            return fx(x,y);
        }

        // [MethodImpl(Inline)]
        // static BinaryOp<T>  create<T>(T x, T y, Identifier name, ReadOnlySpan<byte> f)
        //     where T : unmanaged
        //         => BinaryOpFactory.create<T>(name, new BinaryCode(f.ToArray()));

        // [MethodImpl(Inline)]
        // static BinaryOp<T> create<T>(T x, T y, Identifier name, BinaryCode f)
        //     where T : unmanaged
        //         => BinaryOpFactory.create<T>(name, f);
    }
}