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
        public static string format(UnaryArithmeticApiKey kind)
            => kind switch {
                UnaryArithmeticApiKey.Inc => "++",
                UnaryArithmeticApiKey.Dec => "--",
                UnaryArithmeticApiKey.Negate => "-",
                _ => kind.ToString()
            };

        [MethodImpl(Inline)]
        public static string format<T>(UnaryArithmeticApiKey kind, T arg)
            => $"{kind.Format()}({arg})";

        [MethodImpl(Inline)]
        public static string format(BinaryLogicKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string format<T>(BinaryLogicKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        [MethodImpl(Inline)]
        public static string format<T>(BinaryArithmeticApiKey kind, T arg1, T arg2)
            => $"{kind.ToString().ToLower()}({arg1}, {arg2})";

        [MethodImpl(Inline)]
        public static string format(BinaryComparisonApiKey kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string format<T>(BinaryComparisonApiKey kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";
    }
}