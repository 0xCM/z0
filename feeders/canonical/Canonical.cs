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
    using System.Collections.Generic;
    using System.Linq;

    using static Components;
    
    using T = PartIdentity;

    public static class Canonical
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    
        public static IEnumerable<IPartId> Dependencies
            => core.seq<IPartId>(T.Components.Part, T.Monadic.Part);
    }

    public static partial class XCanonical    
    {

    }
}
