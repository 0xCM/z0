//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.DVec)]

namespace Z0.Parts
{
    public sealed class DVec : Part<DVec>
    {        
        
    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    /// <summary>
    /// Direct vectorized intrinsics
    /// </summary>
    [ApiHost(ApiHostKind.Direct)]
    public static partial class dvec
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;    
    }

}