//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    [ApiHost(ApiNames.SpanBlocks)]
    public readonly partial struct SpanBlocks
    {
        const NumericKind Closure = UnsignedInts;
    }
}