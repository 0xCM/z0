//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    [ApiHost(ApiNames.CellOps, true)]
    public readonly partial struct CellOps
    {
        const NumericKind Closure = Integers;

        [MethodImpl(Inline), Op, Closures(Closure)]
        internal static UnaryOp<T> uFx<T>(MethodInfo src, UnaryOpClass<T> k)
            where T : unmanaged
                => Delegates.unary<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        internal static BinaryOp<T> bFx<T>(MethodInfo src, BinaryOpClass<T> K)
            where T : unmanaged
                => Delegates.binary<T>(src);
    }
}