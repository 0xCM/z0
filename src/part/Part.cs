//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: PartId(PartId.Part)]

namespace Z0.Parts
{
    public sealed partial class Part : Part<Part>
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