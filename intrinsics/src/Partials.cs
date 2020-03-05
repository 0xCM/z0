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


    [ApiHost("vpattern", ApiHostKind.Generic)]
    public static partial class vpattern
    {

    }

    [ApiHost("bitpack")]
    public static partial class bitpack
    {

    }

    public static partial class CpuVector
    {
    
    }    

    public static partial class CpuVecX
    {

    }
    
    /// <summary>
    /// Direct vectorized intrinsics over floating-point domains
    /// </summary>
    [ApiHost(ApiHostKind.Direct)]
    public static partial class dinxfp
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
    [ApiHost(ApiHostKind.Direct)]
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

    [ApiHost]
    public static partial class vmask
    {
    }


}