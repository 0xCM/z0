//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: PartId(PartId.Digital)]

namespace Z0.Parts
{
    public sealed partial class Digital : Part<Digital>
    {

    }
}

namespace Z0
{
    [ApiHost]
    public static partial class XTend
    {

    }
}