//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Monadic)]

namespace Z0.Parts
{        
    public sealed class Monadic : Part<Monadic>
    {


    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class Monadic
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }
}
