//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.CompilerServices;
    using static zfunc;


    /// <summary>
    /// Direct vectorized intrinsics
    /// </summary>
    public static partial class dinx
    {

    }

    /// <summary>
    /// Direct vectorized intrinsics over floating-point domains
    /// </summary>
    public static partial class dinxfp
    {
        [MethodImpl(Inline)]
        static FloatComparisonMode fpmode(FpCmpMode m)
            => (FloatComparisonMode)m;
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
    public static partial class ginx
    {        
        public static IEnumerable<MethodInfo> BinOps()
        {
            return typeof(ginx).Methods().Public().OpenGeneric().Where(x => x.ParameterTypes().Count() == 2);
        }

    }


    /// <summary>
    /// Generic vectorized intrinsics over floating-point domains
    /// </summary>
    public static partial class ginxfp
    {
        
    }

    /// <summary>
    /// Generic scalar intrinsics over floating-point domains
    /// </summary>
    public static partial class ginxsfp
    {


    }

    /// <summary>
    /// Generic scalar intrinsics
    /// </summary>
    public static partial class ginxs
    {

    }

    public static partial class VOps
    {

    }
}