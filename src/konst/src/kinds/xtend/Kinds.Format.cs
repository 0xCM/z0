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
        public static string Format(this ComparisonApiKeyKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this ComparisonApiKeyKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        public static string Format(this ApiKeyId id)
            => id.ToString().ToLower();

        public static string Format(this ApiKeyId id, bool vectorized)
            => vectorized ? $"v{id.Format()}" : id.Format();

        public static string Format(this ApiKeyId? id)
            => id.HasValue ? id.Value.Format() : "unkinded";

        [MethodImpl(Inline)]
        public static string Format(this ArithmeticApiKeyKind kind)
            => kind switch {
                ArithmeticApiKeyKind.Inc => "++",
                ArithmeticApiKeyKind.Dec => "--",
                ArithmeticApiKeyKind.Negate => "-",
                _ => kind.ToString()
            };

        [MethodImpl(Inline)]
        public static string Format<T>(this ArithmeticApiKeyKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        public static string Format(this BitShiftApiKeyKind kind)
            => kind switch {
                BitShiftApiKeyKind.Sll => "<<",
                BitShiftApiKeyKind.Srl => ">>",
                BitShiftApiKeyKind.Rotl => "<<>",
                BitShiftApiKeyKind.Rotr => ">><",
                _ => kind.ToString()
            };

        public static string Format<S,T>(this BitShiftApiKeyKind kind, S arg1, T arg2)
            => $"{arg1} {kind.Format()} {arg2}";


        [MethodImpl(Inline)]
        public static string Format(this BitLogicApiKeyKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this BitLogicApiKeyKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";
    }
}