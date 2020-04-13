//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    

    /// <summary>
    /// Base type for intrinsic tests
    /// </summary>
    /// <typeparam name="X">The concrete subtype</typeparam>
    public abstract class t_inx<X> : UnitTest<X>
        where X : t_inx<X>
    {
        protected IVectorCheck Claim => IVectorCheck.Checker;
    }
}