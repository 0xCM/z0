//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zfunc;
    using static SpanKind;

    public enum SpanKind
    {
        None = 0,

        Mutable = 1,

        Immutable = 2
    }

    public static class SpanKindExtensions
    {
        /// <summary>
        /// Classifies a type according to whether it is a span, a readonly span, or otherwise
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static SpanKind SpanKind(this Type t)
            => t.GenericDefinition() == typeof(Span<>) ? Mutable
              : t.GenericDefinition() == typeof(ReadOnlySpan<>) ? Immutable
              : 0;

        [MethodImpl(Inline)]
        public static bool IsSome(this SpanKind kind)
            => kind != 0;

        [MethodImpl(Inline)]
        public static bool IsNone(this SpanKind kind)
            => kind == 0;

        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSpan(this Type t)
            => t.SpanKind().IsSome();

        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsNatSpan(this Type t)
            => NatSpanSig.From(t).IsSome();

        public static string Format(this SpanKind kind)
            => kind.IsSome() ? (kind == Mutable ? IDI.Span : IDI.USpan) : string.Empty;

    }
}