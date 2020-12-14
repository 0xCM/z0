//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Reflection;
[assembly: PartId(PartId.Dsl)]
namespace Z0.Parts
{
    public sealed class Dsl : Part<Dsl>
    {
    }
}

namespace Z0
{
    public static partial class XTend{}
}