//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: AssemblyDescription("The root of things, better than most, no doubt worse than others")]
[assembly: PartId(PartId.Rooted)]

namespace Z0.Parts
{        
    public sealed class Rooted : Part<Rooted>
    {

    }
}
