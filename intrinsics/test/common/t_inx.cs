//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    /// <summary>
    /// Base type for intrinsic tests
    /// </summary>
    /// <typeparam name="X">The concrete subtype</typeparam>
    public abstract class t_inx<X> : UnitTest<X>
        where X : t_inx<X>
    {
        protected IFunc<Vector128<T>> vemitter<T>(N128 w, T t = default)
            where T : unmanaged
                => VRng.VEmitter(w,Random,t);
        
        protected IFunc<Vector256<T>> vemitter<T>(N256 w, T t = default)
            where T : unmanaged
                => VRng.VEmitter(w,Random,t);


    }

}