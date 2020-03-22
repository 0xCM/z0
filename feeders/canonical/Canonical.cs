//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Canonical)]

namespace Z0.Parts
{        
    public sealed class Canonical : Part<Canonical> { }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class Canonical
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }

    public static partial class CanonicalOps    
    {

    }
}
