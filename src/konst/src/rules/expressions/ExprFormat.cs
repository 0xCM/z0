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
        [Op]
        public static string format(UnaryBitLogicKind kind)
            => kind.ToString().ToLower();

        [Op]
        public static string format<T>(UnaryBitLogicKind kind, T arg)
            => $"{kind.Format()}({arg})";

        [Op]
        public static string format(BinaryBitLogicKind kind)
            => kind.ToString().ToLower();

        [Op]
        public static string format<T>(BinaryBitLogicKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        [Op]
        public static string format(ComparisonApiClass kind)
            => kind.ToString().ToLower();

        [Op]
        public static string format(UnaryArithmeticApiClass kind)
            => kind switch {
                UnaryArithmeticApiClass.Inc => "++",
                UnaryArithmeticApiClass.Dec => "--",
                UnaryArithmeticApiClass.Negate => "-",
                _ => kind.ToString()
            };

        public static string format<T>(UnaryArithmeticApiClass kind, T arg)
            => $"{kind.Format()}({arg})";

        public static string format<T>(BinaryArithmeticApiClass kind, T arg1, T arg2)
            => $"{kind.ToString().ToLower()}({arg1}, {arg2})";

        public static string format<T>(ComparisonApiClass kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";
    }
}