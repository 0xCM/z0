//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class DynamicOperators
    {
        [MethodImpl(Inline)]
        public static IDynamicEmitterFactory<T> DynamicOperatorFactory<T>(this IContext context, N0 n, T t = default)        
            => new DynamicEmitterFactory<T>(context);

        [MethodImpl(Inline)]
        public static IDynamicUnaryOpFactory<T> DynamicOperatorFactory<T>(this IContext context, N1 n, T t = default)        
            => new DynamicUnaryOpFactory<T>(context);

        [MethodImpl(Inline)]
        public static IDynamicBinaryOpFactory<T> DynamicOperatorFactory<T>(this IContext context, N2 n, T t = default)        
            => new DynamicBinaryOpFactory<T>(context);

        [MethodImpl(Inline)]
        public static IDynamicTernaryOpFactory<T> DynamicOperatorFactory<T>(this IContext context, N3 n, T t = default)        
            => new DynamicTernaryOpFactory<T>(context);
    }
}