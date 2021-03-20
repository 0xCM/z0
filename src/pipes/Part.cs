//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

[assembly: PartId(PartId.Pipes)]

namespace Z0.Parts
{
    public sealed class Pipes : Part<Pipes>
    {

    }
}

namespace Z0
{
    [ApiHost]
    public static partial class XCell
    {
        const NumericKind Closure = NumericKind.UnsignedInts;
    }

}

