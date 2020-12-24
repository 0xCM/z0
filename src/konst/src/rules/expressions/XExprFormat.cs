//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public static class XExprFormat
    {
        [MethodImpl(Inline)]
        public static string Format(this UnaryBitLogicKind kind)
            => ExprFormat.format(kind);

        [MethodImpl(Inline)]
        public static string Format<T>(this UnaryBitLogicKind kind, T arg)
            => ExprFormat.format(kind,arg);

        [MethodImpl(Inline)]
        public static string Format(this UnaryArithmeticApiClass kind)
            => ExprFormat.format(kind);

        [MethodImpl(Inline)]
        public static string Format<T>(this UnaryArithmeticApiClass kind, T arg)
            => ExprFormat.format(kind, arg);

        [MethodImpl(Inline)]
        public static string Format(this BinaryBitLogicKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryBitLogicKind kind, T arg1, T arg2)
            => ExprFormat.format(kind, arg1, arg2);

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryArithmeticApiClass kind, T arg1, T arg2)
            => ExprFormat.format(kind, arg1, arg2);

        [MethodImpl(Inline)]
        public static string Format(this BinaryComparisonApiClass kind)
            => ExprFormat.format(kind);

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryComparisonApiClass kind, T arg1, T arg2)
            => ExprFormat.format(kind, arg1, arg2);
    }
}