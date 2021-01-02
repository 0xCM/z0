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
    public readonly partial struct ApiOperators
    {
        [MethodImpl(Inline), Op]
        public static ComparisonOperation define(ComparisonKind kind, byte arity, Type tOperand, Type tResult)
            => new ComparisonOperation(kind, arity, tOperand, tResult);

        [MethodImpl(Inline), Op]
        public static ComparisonOperation binop<T,R>(ComparisonKind kind)
            => define(kind, 2, typeof(T), typeof(R));

        [MethodImpl(Inline), Op]
        public static ComparisonOperation binop(ComparisonKind kind, Type tOperand, Type tResult)
            => define(kind, 2, tOperand, tResult);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ComparisonOperation binop1u<T>(ComparisonKind kind)
            => define(kind, 2, typeof(T), typeof(bit));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ComparisonOperation binop1u(ComparisonKind kind, Type tOperand)
            => define(kind, 2, tOperand, typeof(bit));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ComparisonOperation binopbool<T>(ComparisonKind kind)
            => define(kind, 2, typeof(T), typeof(bool));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ComparisonOperation binopbool(ComparisonKind kind, Type tOperand)
            => define(kind, 2, tOperand, typeof(bool));
    }
}