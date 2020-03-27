//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines generic floating-point operations
    /// </summary>
    [ApiHost(ApiHostKind.Generic)]
    public static partial class gfp
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }

}