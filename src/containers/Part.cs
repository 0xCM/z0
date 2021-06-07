//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Containers)]

namespace Z0.Parts
{
    public sealed partial class Containers : Part<Containers>
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

    [ApiHost]
    public static partial class ContainersQuery
    {
        const NumericKind Closure = Root.UnsignedInts;
    }
}