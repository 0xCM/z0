//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: PartId(PartId.Memory)]

namespace Z0.Parts
{
    public sealed partial class Memory : Part<Memory>
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