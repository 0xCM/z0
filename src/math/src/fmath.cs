//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines floating-point operations
    /// </summary>
    [ApiHost]
    public partial class fmath : IApiHost<fmath>
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }
}