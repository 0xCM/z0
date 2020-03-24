//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Identify)]

namespace Z0.Parts
{        
    public sealed class Identify : Part<Identify>
    {


    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class Identify
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }

}
