//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Expr
{
    using static Root;

    [ApiHost("expr.api")]
    public readonly partial struct expr
    {
        const NumericKind Closure = UnsignedInts;        
    }
}