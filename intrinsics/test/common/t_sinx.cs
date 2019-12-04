//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    /// <summary>
    /// Base type for scalar intrinsic tests
    /// </summary>
    /// <typeparam name="X">The concrete subtype</typeparam>
    public abstract class t_sinx<X> : t_inx<X>
        where X : t_sinx<X>
    {

    }

}