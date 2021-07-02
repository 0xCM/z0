//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: PartId(PartId.Text)]

namespace Z0.Parts
{
    public sealed partial class Text : Part<Text>
    {

    }
}

namespace Z0
{
    [ApiHost]
    public static partial class XTend
    {
        const NumericKind Closure = Root.UnsignedInts;
    }

    [ApiHost]
    public static partial class XText
    {

    }
}