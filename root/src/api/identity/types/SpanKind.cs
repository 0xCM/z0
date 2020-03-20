//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static SpanKind;

    public enum SpanKind
    {
        None = 0,

        Mutable = 1,

        Immutable = 2
    }

    public static class SpanKindOps
    {
        public static string Format(this SpanKind kind)
            => kind != 0 ? (kind == Mutable ? IDI.Span : IDI.USpan) : string.Empty;
    }    
}