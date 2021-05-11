//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    partial class XApi
    {
        public static string Format(this Type src)
            => src.Name.Replace("`1", EmptyString).Replace("`2", EmptyString);

        public static string Format(this MethodInfo src)
            => src.ToString().Replace("`1", EmptyString).Replace("`2", EmptyString);

        public static string Format(this Assembly src)
            => src.GetSimpleName();

       [Op]
       public static string Format(this ApiUriScheme src)
            => src.ToString().ToLower();

        [MethodImpl(Inline), Op]
        public static string Format(this SpanKind kind)
            => kind != 0 ? (kind == SpanKind.Mutable ? IDI.Span : IDI.ReadOnlySpan) : EmptyString;

        [MethodImpl(Inline), Op]
        public static string Format(this ApiComparisonClass kind)
            => kind.ToString().ToLower();

        [Op]
        public static string Format(this ApiClassKind? id)
            => id.HasValue ? id.Value.Format() : "unkinded";

        [Op]
        public static string Format(this ApiArithmeticClass key)
            => key switch {
                ApiArithmeticClass.Inc => "++",
                ApiArithmeticClass.Dec => "--",
                ApiArithmeticClass.Negate => "-",
                _ => key.ToString()
            };

        [Op, Closures(Closure)]
        public static string Format<T>(this ApiArithmeticClass key, T a, T b)
            => $"{key.Format()}({a}, {b})";

        [Op]
        public static string Format(this ApiBitShiftClass kind)
            => kind switch {
                ApiBitShiftClass.Sll => "<<",
                ApiBitShiftClass.Srl => ">>",
                ApiBitShiftClass.Rotl => "<<>",
                ApiBitShiftClass.Rotr => ">><",
                _ => kind.ToString()
            };

        [Op]
        public static string Format<S,T>(this ApiBitShiftClass key, S a, T b)
            => $"{a} {key.Format()} {b}";

        [Op]
        public static string Format(this ApiBitLogicClass key)
            => key.ToString().ToLower();

        [Op, Closures(Closure)]
        public static string Format<T>(this ApiBitLogicClass key, T a, T b)
            => string.Format("{0}({1}, {2})", key.Format(), a, b);



    }
}