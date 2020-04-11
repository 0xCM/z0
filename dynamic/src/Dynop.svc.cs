//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static VectorKinds;

    using C = OpClasses;

    [ServiceFactory]
    public static partial class ServiceFactory
    {

    }

    public static class DynopServices
    {
        [MethodImpl(Inline)]
        public static IImmInjector VUnaryImmInjector<W>(this IContext context, W w = default)
            where W : ITypeWidth
        {
            if(typeof(W) == typeof(W128))
                return new ImmInjector(context, v128, C.UnaryOp);
            else if(typeof(W) == typeof(W256))
                return new ImmInjector(context, v256, C.UnaryOp);
            else 
                throw Unsupported.define<W>();
        }

        [MethodImpl(Inline)]
        public static IImmInjector VBinaryImmInjector<W>(this IContext context, W w = default)
            where W : ITypeWidth
        {
            if(typeof(W) == typeof(W128))
                return new ImmInjector(context, v128, C.BinaryOp);
            else if(typeof(W) == typeof(W256))
                return new ImmInjector(context, v256, C.BinaryOp);
            else 
                throw Unsupported.define<W>();
        }

        [MethodImpl(Inline)]
        public static IImmInjector<UnaryOp<Vector128<T>>> V128UnaryOpImmInjector<T>(this IContext context)
            where T : unmanaged
                => new ImmInjector<UnaryOp<Vector128<T>>>(context, new V128UnaryOpImmInjector<T>(context));

        [MethodImpl(Inline)]
        public static IImmInjector<BinaryOp<Vector128<T>>> V128BinaryOpImmInjector<T>(this IContext context)
            where T : unmanaged
                => new ImmInjector<BinaryOp<Vector128<T>>>(context, new V1286BinaryOpImmInjector<T>(context));

        [MethodImpl(Inline)]
        public static IImmInjector<UnaryOp<Vector256<T>>> V256UnaryOpImmInjector<T>(this IContext context)
            where T : unmanaged
                => new ImmInjector<UnaryOp<Vector256<T>>>(context, new V256UnaryOpImmInjector<T>(context));

        [MethodImpl(Inline)]
        public static IImmInjector<BinaryOp<Vector256<T>>> V256BinaryOpImmInjector<T>(this IContext context)
            where T : unmanaged
                => new ImmInjector<BinaryOp<Vector256<T>>>(context, new V256BinaryOpImmInjector<T>(context));
    }
}