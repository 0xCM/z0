//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Core)]

namespace Z0.Parts
{        
    public sealed class Core : Part<Core> { }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static partial class Core 
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public const MethodImplOptions NotInline = MethodImplOptions.NoInlining;

    }

    public static partial class XTend { }
}