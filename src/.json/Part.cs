//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: AssemblyDescription("A -> Json -> B")]
[assembly: PartId(PartId.Json)]

namespace Z0.Parts
{
    public sealed class Json : Part<Json>
    {
        public override PartId[] Needs
            => parts(PartId.Konst);
    }
}

namespace Z0
{
    public static partial class XTend
    {
    }
}