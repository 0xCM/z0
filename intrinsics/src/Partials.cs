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

    public static partial class dinx
    {

    }

    public static partial class dinxx
    {
        
    }

    public static partial class ginxx
    {        

    }

    /// <summary>
    /// Namescope for custom intrinsic operators
    /// </summary>
    public static partial class dinxc
    {

    }

    /// <summary>
    /// Defines direct floating-point operations
    /// </summary>
    public static partial class dfp
    {
        [MethodImpl(Inline)]
        static FloatComparisonMode fpmode(FpCmpMode m)
            => (FloatComparisonMode)m;


    }
    public static partial class dfpx
    {


    }
    public static partial class ginx
    {        
        public static IEnumerable<MethodInfo> BinOps()
        {
            return typeof(ginx).Methods().Public().OpenGeneric().Where(x => x.ParameterTypes().Count() == 2);
        }

    }

    /// <summary>
    /// Opcodes for intrinsic vectorized operations
    /// </summary>
    public static partial class inxoc
    {

    }

    /// <summary>
    /// Opcodes for intrinsic scalar operations
    /// </summary>
    public static partial class inxoc    
    {

    }

    /// <summary>
    /// Opcodes for custom intrinsic operations
    /// </summary>
    public static partial class inxcoc
    {

    }

    public static partial class vblock
    {
        
    }

}