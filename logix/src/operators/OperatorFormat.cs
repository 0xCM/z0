//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public static partial class XTend
    {
        [MethodImpl(Inline)]
        public static string Format(this UnaryLogicKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this UnaryLogicKind kind, T arg)
            => $"{kind.Format()}({arg})";

        [MethodImpl(Inline)]
        public static string Format(this UnaryArithmeticKind kind)
            => kind switch {
                UnaryArithmeticKind.Inc => "++",
                UnaryArithmeticKind.Dec => "--",
                UnaryArithmeticKind.Negate => "-",
                _ => kind.ToString()
            };

        [MethodImpl(Inline)]
        public static string Format<T>(this UnaryArithmeticKind kind, T arg)
            => $"{kind.Format()}({arg})";

        [MethodImpl(Inline)]
        public static string Format(this BinaryLogicKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryLogicKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryArithmeticKind kind, T arg1, T arg2)
            => $"{kind.ToString().ToLower()}({arg1}, {arg2})";

        [MethodImpl(Inline)]
        public static string Format(this BinaryComparisonKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryComparisonKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";
    }
}