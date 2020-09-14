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
        public static string format(UnaryBitLogicKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string format<T>(UnaryBitLogicKind kind, T arg)
            => $"{kind.Format()}({arg})";

        [MethodImpl(Inline)]
        public static string format(UnaryArithmeticApiKeyKind kind)
            => kind switch {
                UnaryArithmeticApiKeyKind.Inc => "++",
                UnaryArithmeticApiKeyKind.Dec => "--",
                UnaryArithmeticApiKeyKind.Negate => "-",
                _ => kind.ToString()
            };

        [MethodImpl(Inline)]
        public static string format<T>(UnaryArithmeticApiKeyKind kind, T arg)
            => $"{kind.Format()}({arg})";

        [MethodImpl(Inline)]
        public static string format(BinaryLogicKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string format<T>(BinaryLogicKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        [MethodImpl(Inline)]
        public static string format<T>(BinaryArithmeticApiKeyKind kind, T arg1, T arg2)
            => $"{kind.ToString().ToLower()}({arg1}, {arg2})";

        [MethodImpl(Inline)]
        public static string format(BinaryComparisonApiKeyKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string format<T>(BinaryComparisonApiKeyKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";
    }
}