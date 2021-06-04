//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: PartId(PartId.Commands)]

namespace Z0.Parts
{
    public sealed partial class Commands : Part<Commands>
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