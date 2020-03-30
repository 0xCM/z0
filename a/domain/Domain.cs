//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Domain)]

namespace Z0.Parts
{        
    public sealed class Domain : Part<Domain> { }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class Domain
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;        

    }

    public static partial class XDomain    
    {

    }

    public static partial class XTend    
    {

    }    
}
