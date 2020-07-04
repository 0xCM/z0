//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: AssemblyDescription("I am a part, a harbinger of the many")]
[assembly: PartId(PartId.Part)]

namespace Z0.Parts
{        
    public sealed class Part : Part<Part>
    {

    }
}