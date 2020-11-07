//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ExprFormat
    {
        [MethodImpl(Inline)]
        public static string format(UnaryBitLogicKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string format<T>(UnaryBitLogicKind kind, T arg)
            => $"{kind.Format()}({arg})";

        [MethodImpl(Inline)]
        public static string format(BinaryBitLogicKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string format<T>(BinaryBitLogicKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        [MethodImpl(Inline)]
        public static string format(BinaryComparisonApiClass kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string format(UnaryArithmeticApiClass kind)
            => kind switch {
                UnaryArithmeticApiClass.Inc => "++",
                UnaryArithmeticApiClass.Dec => "--",
                UnaryArithmeticApiClass.Negate => "-",
                _ => kind.ToString()
            };

        [MethodImpl(Inline)]
        public static string format<T>(UnaryArithmeticApiClass kind, T arg)

            => $"{kind.Format()}({arg})";


        [MethodImpl(Inline)]
        public static string format<T>(BinaryArithmeticApiClass kind, T arg1, T arg2)
            => $"{kind.ToString().ToLower()}({arg1}, {arg2})";


        [MethodImpl(Inline)]
        public static string format<T>(BinaryComparisonApiClass kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";
    }
}