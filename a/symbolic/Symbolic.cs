//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Symbolic)]

namespace Z0.Parts
{
    public sealed class Symbolic : Part<Symbolic> {  }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    public static class Symbolic
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;


    }
}