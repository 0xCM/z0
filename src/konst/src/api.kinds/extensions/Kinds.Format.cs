//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XKinds
    {
        [MethodImpl(Inline), Op]
        public static string Format(this SpanKind kind)
            => kind != 0 ? (kind == SpanKind.Mutable ? IDI.Span : IDI.ReadOnlySpan) : EmptyString;

        [MethodImpl(Inline)]
        public static string Format<K>(this K kind)
            where K : IApiKey
                => kind.Format();

        [MethodImpl(Inline), Op]
        public static string Format(this ComparisonApiKey kind)
            => kind.ToString().ToLower();

        [Op, Closures(Closure)]
        public static string Format<T>(this ComparisonApiKey kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        [Op]
        public static string Format(this ApiOpId id, bool vectorized)
            => vectorized ? $"v{id.Format()}" : id.Format();

        [Op]
        public static string Format(this ApiOpId? id)
            => id.HasValue ? id.Value.Format() : "unkinded";

        [Op]
        public static string Format(this ArithmeticApiKey key)
            => key switch {
                ArithmeticApiKey.Inc => "++",
                ArithmeticApiKey.Dec => "--",
                ArithmeticApiKey.Negate => "-",
                _ => key.ToString()
            };

        [Op, Closures(Closure)]
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

        [Op]
        public static string Format<S,T>(this BitShiftApiKey key, S a, T b)
            => $"{a} {key.Format()} {b}";

        [Op]
        public static string Format(this BinaryBitLogicApiKey key)
            => key.ToString().ToLower();

        [Op, Closures(Closure)]
        public static string Format<T>(this BinaryBitLogicApiKey key, T a, T b)
            => text.format("{0}({1}, {2})", key.Format(), a, b);
    }
}