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


    public static partial class MathX
    {

    }


    static class App
    {
        public static void Main(params string[] args) { }
    }

}