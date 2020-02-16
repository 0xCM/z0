//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static RootShare;    
    using static SpanKind;

    public enum SpanKind
    {
        None = 0,

        Mutable = 1,

        Immutable = 2
    }

    public static class SpanKindOps
    {
        [MethodImpl(Inline)]
        public static bool IsSome(this SpanKind kind)
            => kind != 0;

        [MethodImpl(Inline)]
        public static bool IsNone(this SpanKind kind)
            => kind == 0;

        public static string Format(this SpanKind kind)
            => kind.IsSome() ? (kind == Mutable ? IDI.Span : IDI.USpan) : string.Empty;
    }
}