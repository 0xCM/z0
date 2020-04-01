//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    using C = OpClass;

    partial class ServiceFactory
    {
        [MethodImpl(Inline)]
        public static IEmitterFactory<T> OperatorFactory<T>(this IContext context, C.Emitter<T> op)        
            where T : unmanaged
                => default(EmitterFactory<T>);

        [MethodImpl(Inline)]
        public static IUnaryOpFactory<T> OperatorFactory<T>(this IContext context, C.UnaryOp<T> op)        
            where T : unmanaged
                => default(UnaryOpFactory<T>);

        [MethodImpl(Inline)]
        public static IBinaryOpFactory<T> OperatorFactory<T>(this IContext context, C.BinaryOp<T> op)        
            where T : unmanaged
                => default(BinaryOpFactory<T>);

        [MethodImpl(Inline)]
        public static ITernaryOpFactory<T> OperatorFactory<T>(this IContext context, C.TernaryOp<T> op)        
            where T : unmanaged
                => default(TernaryOpFactory<T>);
    }
}