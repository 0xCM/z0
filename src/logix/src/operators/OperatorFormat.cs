//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ExprFormat
    {
        [MethodImpl(Inline)]
        public static string format(UnaryBitLogic kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string format<T>(UnaryBitLogic kind, T arg)
            => $"{kind.Format()}({arg})";

        [MethodImpl(Inline)]
        public static string format(UnaryArithmeticOpId kind)
            => kind switch {
                UnaryArithmeticOpId.Inc => "++",
                UnaryArithmeticOpId.Dec => "--",
                UnaryArithmeticOpId.Negate => "-",
                _ => kind.ToString()
            };

        [MethodImpl(Inline)]
        public static string format<T>(UnaryArithmeticOpId kind, T arg)
            => $"{kind.Format()}({arg})";

        [MethodImpl(Inline)]
        public static string format(BinaryLogicKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string format<T>(BinaryLogicKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        [MethodImpl(Inline)]
        public static string format<T>(BinaryArithmeticOpId kind, T arg1, T arg2)
            => $"{kind.ToString().ToLower()}({arg1}, {arg2})";

        [MethodImpl(Inline)]
        public static string format(BinaryComparisonOpId kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string format<T>(BinaryComparisonOpId kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";
    }
}