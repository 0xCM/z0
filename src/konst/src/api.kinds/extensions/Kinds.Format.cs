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
        public static string Format(this ComparisonApiClass kind)
            => kind.ToString().ToLower();

        [Op, Closures(Closure)]
        public static string Format<T>(this ComparisonApiClass kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        [Op]
        public static string Format(this ApiClass id, bool vectorized)
            => vectorized ? $"v{id.Format()}" : id.Format();

        [Op]
        public static string Format(this ApiClass? id)
            => id.HasValue ? id.Value.Format() : "unkinded";

        [Op]
        public static string Format(this ArithmeticApiClass key)
            => key switch {
                ArithmeticApiClass.Inc => "++",
                ArithmeticApiClass.Dec => "--",
                ArithmeticApiClass.Negate => "-",
                _ => key.ToString()
            };

        [Op, Closures(Closure)]
        public static string Format<T>(this ArithmeticApiClass key, T a, T b)
            => $"{key.Format()}({a}, {b})";

        [Op]
        public static string Format(this BitShiftApiClass kind)
            => kind switch {
                BitShiftApiClass.Sll => "<<",
                BitShiftApiClass.Srl => ">>",
                BitShiftApiClass.Rotl => "<<>",
                BitShiftApiClass.Rotr => ">><",
                _ => kind.ToString()
            };

        [Op]
        public static string Format<S,T>(this BitShiftApiClass key, S a, T b)
            => $"{a} {key.Format()} {b}";

        [Op]
        public static string Format(this BinaryBitLogicApiClass key)
            => key.ToString().ToLower();

        [Op, Closures(Closure)]
        public static string Format<T>(this BinaryBitLogicApiClass key, T a, T b)
            => text.format("{0}({1}, {2})", key.Format(), a, b);
    }
}