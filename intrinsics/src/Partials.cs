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
    /// Namescope for custom intrinsic operators
    /// </summary>
    public static partial class dinxc
    {

    }


    public static partial class dfpx
    {


    }

    /// <summary>
    /// Direct vectorized intrinsics
    /// </summary>
    public static partial class dinx
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
    /// Direct vectorized floating-point intrinsics
    /// </summary>
    public static partial class fpinx
    {
        [MethodImpl(Inline)]
        static FloatComparisonMode fpmode(FpCmpMode m)
            => (FloatComparisonMode)m;
    }

    /// <summary>
    /// Generic floating-point intrinsics
    /// </summary>
    public static partial class gfpinx
    {

    }


    /// <summary>
    /// Direct scalar intrinsics
    /// </summary>
    public static partial class inxs
    {

    }

    /// <summary>
    /// Generic scalar intrinsics
    /// </summary>
    public static partial class ginxs
    {

    }

    /// <summary>
    /// Internal helpers
    /// </summary>
    internal static partial class aux
    {

    }

}