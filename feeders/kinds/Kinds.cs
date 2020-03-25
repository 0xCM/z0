//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Kinds)]

namespace Z0.Parts
{        
    public sealed class Kinds : Part<Kinds>
    {


    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class Kinds
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }
}
