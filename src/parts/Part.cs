//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: AssemblyDescription("The root of the knowable part tree")]
[assembly: PartId(PartId.Part)]

namespace Z0.Parts
{        
    public sealed class Part : Part<Part>
    {

    }
}
