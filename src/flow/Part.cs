//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: AssemblyDescription("A -> B")]
[assembly: PartId(PartId.Flow)]

namespace Z0.Parts
{        
    public sealed class Flow : Part<Flow> { }
}
