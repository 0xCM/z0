//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Clr)]

namespace Z0.Parts
{
    public sealed partial class Clr : Part<Clr>
    {

    }
}

namespace Z0
{
    using static Root;

    [ApiHost]
    public static partial class XTend
    {
        const NumericKind Closure = UnsignedInts;

    }
}