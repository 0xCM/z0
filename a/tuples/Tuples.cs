//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Tuples)]

namespace Z0.Parts
{        
    public sealed class Tuples : Part<Tuples> { }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static partial class Tuples
    {        
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;        
    }
}
