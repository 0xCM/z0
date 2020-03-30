//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Cast)]

namespace Z0.Parts
{        
    public sealed class Cast : Part<Cast> { }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [ApiHost]
    public static partial class Cast
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    }

    public static partial class XTend
    {
        
    }
}
