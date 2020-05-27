//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: AssemblyDescription("Data <=> Code")]
[assembly: PartId(PartId.Generate)]

namespace Z0.Parts
{        
    public sealed class Generate : Part<Generate> { }
}
