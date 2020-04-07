//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: AssemblyDescription("Things within")]
[assembly: PartId(PartId.Contained)]

namespace Z0.Parts
{        
    public sealed class Contained : Part<Contained>
    {

    }
}