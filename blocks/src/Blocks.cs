//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Blocks)]

namespace Z0.Parts
{        
    public sealed class Blocks : Part<Blocks>
    {
        
    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
     
    [ApiHost("api")]
    public static partial class Blocks
    {
        //internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    }

    public static partial class XBlocks    
    {
    
    }    

    public static partial class XTend
    {

        
    }
}