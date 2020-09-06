//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public enum SpanKind
    {
        None = 0,

        Mutable = 1,

        Immutable = 2,

        Custom = 3
    }

    partial class XTend
    {
        public static string Format(this SpanKind kind)
            => kind != 0 ? (kind == SpanKind.Mutable ? IDI.Span : IDI.USpan) : string.Empty;
    }    
}