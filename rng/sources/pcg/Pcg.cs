//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.RngPcg)]

namespace Z0.Parts
{        
    public sealed class RngPcg : Part<RngPcg>
    {


    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static partial class RngPcg
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }
}