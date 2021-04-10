//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

[assembly: PartId(PartId.SpanBlocks)]

namespace Z0.Parts
{
    public sealed class SpanBlocks : Part<SpanBlocks>
    {

    }
}

namespace Z0
{
    [ApiHost]
    public static partial class XTend
    {
        const NumericKind Closure = NumericKind.UnsignedInts;
    }

}

