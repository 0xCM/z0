//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Reflections)]

namespace Z0.Parts
{        
    public sealed class Reflections : Part<Reflections>
    {


    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    public static partial class Reflections
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }
}
