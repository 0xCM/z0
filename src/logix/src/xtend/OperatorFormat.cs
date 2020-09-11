//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public static partial class XTend
    {
        [MethodImpl(Inline)]
        public static string Format(this UnaryBitLogic kind)
            => ExprFormat.format(kind);

        [MethodImpl(Inline)]
        public static string Format<T>(this UnaryBitLogic kind, T arg)
            => ExprFormat.format(kind,arg);

        [MethodImpl(Inline)]
        public static string Format(this UnaryArithmeticOpId kind)
            => ExprFormat.format(kind);

        [MethodImpl(Inline)]
        public static string Format<T>(this UnaryArithmeticOpId kind, T arg)
            => ExprFormat.format(kind, arg);

        [MethodImpl(Inline)]
        public static string Format(this BinaryLogicKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryLogicKind kind, T arg1, T arg2)
            => ExprFormat.format(kind, arg1, arg2);

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryArithmeticOpId kind, T arg1, T arg2)
            => ExprFormat.format(kind, arg1, arg2);

        [MethodImpl(Inline)]
        public static string Format(this BinaryComparisonOpId kind)
            => ExprFormat.format(kind);

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryComparisonOpId kind, T arg1, T arg2)
            => ExprFormat.format(kind, arg1, arg2);
    }

}