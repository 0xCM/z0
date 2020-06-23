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
        public static string Format(this UnaryArithmeticKind kind)
            => ExprFormat.format(kind);

        [MethodImpl(Inline)]
        public static string Format<T>(this UnaryArithmeticKind kind, T arg)
            => ExprFormat.format(kind, arg);

        [MethodImpl(Inline)]
        public static string Format(this BinaryLogicKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryLogicKind kind, T arg1, T arg2)
            => ExprFormat.format(kind, arg1, arg2);

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryArithmeticKind kind, T arg1, T arg2)
            => ExprFormat.format(kind, arg1, arg2);

        [MethodImpl(Inline)]
        public static string Format(this BinaryComparisonKind kind)
            => ExprFormat.format(kind);

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryComparisonKind kind, T arg1, T arg2)
            => ExprFormat.format(kind, arg1, arg2);
    }

}