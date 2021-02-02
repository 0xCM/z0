//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public readonly struct ApiOperand
    {
        public ApiOperandKind Kind {get;}
    }

    public enum ApiOperandKind
    {
        None,

        Bit,

        Primitive,

        Vector,

        Cell,

        Span,

        SpanBlock,
    }
}