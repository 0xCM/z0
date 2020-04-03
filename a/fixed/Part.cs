//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: AssemblyDescription("Width, invariantly")]
[assembly: PartId(PartId.Fixed)]

namespace Z0.Parts
{        
    public sealed class Fixed : Part<Fixed> { }
}
