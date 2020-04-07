//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    /// <summary>
    /// Base type for intrinsic tests
    /// </summary>
    /// <typeparam name="X">The concrete subtype</typeparam>
    public abstract class t_inx<X> : UnitTest<X>
        where X : t_inx<X>
    {
        protected ICheckNumeric Claim => ICheckNumeric.Checker;
    }
}