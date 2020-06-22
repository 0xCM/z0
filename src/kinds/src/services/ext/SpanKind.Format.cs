//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XTend
    {
        public static string Format(this SpanKind kind)
            => kind != 0 ? (kind == SpanKind.Mutable ? IDI.Span : IDI.USpan) : string.Empty;
    }
    
}