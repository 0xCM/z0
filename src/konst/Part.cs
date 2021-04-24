//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Konst)]

namespace Z0.Parts
{
    public sealed class Konst : Part<Konst>
    {

    }

}

namespace Z0
{
    [ApiHost]
    public static partial class XTend
    {
        const NumericKind Closure = Part.UnsignedInts;

    }

    public static partial class XSvc
    {

    }

}