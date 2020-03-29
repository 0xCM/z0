//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Memories)]

namespace Z0.Parts
{        
    public sealed class Memories : Part<Memories> { }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class Memories
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    }

    public static partial class XMem    
    {

    }

    public static partial class XTend
    {
        
    }
}
