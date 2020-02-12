//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    
    using System;
    
    [ApiHost(ApiHostKind.Generic)]
    public static partial class gmath
    {

    }

    [ApiHost(ApiHostKind.Direct)]
    public static partial class math
    {

    }

    /// <summary>
    /// Defines generic floating-point operations
    /// </summary>
    [ApiHost(ApiHostKind.Generic)]
    public static partial class gfp
    {

    }

    /// <summary>
    /// Defines floating-point operations
    /// </summary>
    [ApiHost(ApiHostKind.Direct)]
    public static partial class fmath
    {

    }

    /// <summary>
    /// Defines floating-point extensions
    /// </summary>
    public static partial class fpx
    {

    }

    public static partial class MathX
    {

    }


    [ApiHost(ApiHostKind.Generic)]
    public static partial class mathspan
    {    

    }
    
    public static partial class GXTypes
    {
        
    }

    static class App
    {
        public static void Main(params string[] args) { }
    }

}