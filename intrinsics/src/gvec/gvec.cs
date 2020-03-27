//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;    

    /// <summary>
    /// Generic vectorized intrinsics
    /// </summary>
    [ApiHost(ApiHostKind.Generic)]
    public static partial class gvec
    {        
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;    
    }

}