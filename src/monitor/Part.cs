//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: AssemblyDescription("I'll be watching you")]
[assembly: PartId(PartId.Monitor)]

namespace Z0.Parts
{        
    public sealed class Monitor : Part<Monitor> { }
}