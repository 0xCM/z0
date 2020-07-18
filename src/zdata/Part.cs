//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: AssemblyDescription("Data sourced from hither, thither and yon")]
[assembly: PartId(PartId.ZData)]

namespace Z0.Parts
{        
    public sealed class ZData : Part<ZData> { }
}