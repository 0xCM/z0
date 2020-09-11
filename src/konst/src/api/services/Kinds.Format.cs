//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Determines whether the kind has a nonzero value
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this CellWidth src)
            => src != 0;

        [MethodImpl(Inline)]
        public static string Format(this ComparisonOpId kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this ComparisonOpId kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        public static string Format(this ApiOpId id)
            => id.ToString().ToLower();

        public static string Format(this ApiOpId id, bool vectorized)
            => vectorized ? $"v{id.Format()}" : id.Format();

        public static string Format(this ApiOpId? id)
            => id.HasValue ? id.Value.Format() : "unkinded";

        [MethodImpl(Inline)]
        public static string Format(this ArithmeticOpId kind)
            => kind switch {
                ArithmeticOpId.Inc => "++",
                ArithmeticOpId.Dec => "--",
                ArithmeticOpId.Negate => "-",
                _ => kind.ToString()
            };

        [MethodImpl(Inline)]
        public static string Format<T>(this ArithmeticOpId kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        public static string Format(this BitShiftOpId kind)
            => kind switch {
                BitShiftOpId.Sll => "<<",
                BitShiftOpId.Srl => ">>",
                BitShiftOpId.Rotl => "<<>",
                BitShiftOpId.Rotr => ">><",
                _ => kind.ToString()
            };

        public static string Format<S,T>(this BitShiftOpId kind, S arg1, T arg2)
            => $"{arg1} {kind.Format()} {arg2}";


        [MethodImpl(Inline)]
        public static string Format(this BitLogicOpId kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this BitLogicOpId kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";
    }
}