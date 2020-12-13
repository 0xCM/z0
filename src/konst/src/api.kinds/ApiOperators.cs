//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z ;

    [ApiHost]
    public readonly partial struct ApiOperators
    {
        [MethodImpl(Inline), Op]
        public static ComparisonOperator define(ComparisonKind kind, byte arity, Type tOperand, Type tResult)
            => new ComparisonOperator(kind, arity, tOperand, tResult);

        [MethodImpl(Inline), Op]
        public static ComparisonOperator binop<T,R>(ComparisonKind kind)
            => define(kind, 2, typeof(T), typeof(R));

        [MethodImpl(Inline), Op]
        public static ComparisonOperator binop(ComparisonKind kind, Type tOperand, Type tResult)
            => define(kind, 2, tOperand, tResult);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ComparisonOperator binop1u<T>(ComparisonKind kind)
            => define(kind, 2, typeof(T), typeof(bit));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ComparisonOperator binop1u(ComparisonKind kind, Type tOperand)
            => define(kind, 2, tOperand, typeof(bit));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ComparisonOperator binopbool<T>(ComparisonKind kind)
            => define(kind, 2, typeof(T), typeof(bool));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ComparisonOperator binopbool(ComparisonKind kind, Type tOperand)
            => define(kind, 2, tOperand, typeof(bool));
    }
}