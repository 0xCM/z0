//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class KXTend
    {
        [MethodImpl(Inline), Op]
        public static string Format(this SpanKind kind)
            => kind != 0 ? (kind == SpanKind.Mutable ? IDI.Span : IDI.USpan) : EmptyString;

        [MethodImpl(Inline)]
        public static string Format<K>(this K kind)
            where K : IApiKey
                => kind.Format();

        /// <summary>
        /// Determines whether the kind has a nonzero value
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static bool IsSome(this CellWidth src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static string Format(this ComparisonApiKey kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string Format<T>(this ComparisonApiKey kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        [MethodImpl(Inline), Op]
        public static string Format(this ApiKeyId id)
            => id.ToString().ToLower();

        [MethodImpl(Inline), Op]
        public static string Format(this ApiKeyId id, bool vectorized)
            => vectorized ? $"v{id.Format()}" : id.Format();

        [MethodImpl(Inline), Op]
        public static string Format(this ApiKeyId? id)
            => id.HasValue ? id.Value.Format() : "unkinded";

        [MethodImpl(Inline), Op]
        public static string Format(this ArithmeticApiKey key)
            => key switch {
                ArithmeticApiKey.Inc => "++",
                ArithmeticApiKey.Dec => "--",
                ArithmeticApiKey.Negate => "-",
                _ => key.ToString()
            };

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string Format<T>(this ArithmeticApiKey key, T a, T b)
            => $"{key.Format()}({a}, {b})";

        [Op]
        public static string Format(this BitShiftApiKey kind)
            => kind switch {
                BitShiftApiKey.Sll => "<<",
                BitShiftApiKey.Srl => ">>",
                BitShiftApiKey.Rotl => "<<>",
                BitShiftApiKey.Rotr => ">><",
                _ => kind.ToString()
            };

        public static string Format<S,T>(this BitShiftApiKey key, S a, T b)
            => $"{a} {key.Format()} {b}";

        [MethodImpl(Inline), Op]
        public static string Format(this BinaryBitLogicApiKey key)
            => key.ToString().ToLower();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string Format<T>(this BinaryBitLogicApiKey key, T a, T b)
            => text.format("{0}({1}, {2})", key.Format(), a, b);
    }
}