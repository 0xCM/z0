//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: AssemblyDescription("The root of the knowable part tree")]
[assembly: PartId(PartId.Parts)]

namespace Z0.Parts
{        
    public sealed class Part : Part<Part>
    {

    }
}
