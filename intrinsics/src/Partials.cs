//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Direct vectorized intrinsics
    /// </summary>
    [ApiHost(ApiHostKind.Direct)]
    public static partial class dinx
    {

    }

    [ApiHost(ApiHostKind.Generic)]
    public static partial class vblocks
    {


    }

    [ApiHost("vpattern", ApiHostKind.Generic)]
    public static partial class vpattern
    {

    }

    [ApiHost("bitpack")]
    public static partial class bitpack
    {

    }

    [ApiHost("cpuvector")]
    public static partial class CpuVector
    {
    
    }    

    /// <summary>
    /// Direct vectorized intrinsics over floating-point domains
    /// </summary>
    [ApiHost(ApiHostKind.Direct)]
    public static partial class dinxfp
    {
    }

    [ApiHost]
    public static partial class permute
    {

    }

    /// <summary>
    /// Direct scalar intrinsics
    /// </summary>
    public static partial class dinxs
    {

    }

    /// <summary>
    /// Direct floating-point scalar intrinsics
    /// </summary>
    public static partial class dinxsfp
    {

    }

    /// <summary>
    /// Generic vectorized intrinsics
    /// </summary>
    [ApiHost(ApiHostKind.Generic)]
    public static partial class ginx
    {        

    }

    /// <summary>
    /// Vectorized operators
    /// </summary>
    public static partial class VX
    {

    }

    /// <summary>
    /// Vectorized operator types
    /// </summary>
    public static partial class VXTypes
    {

    }
}