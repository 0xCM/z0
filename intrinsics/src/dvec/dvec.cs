//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
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