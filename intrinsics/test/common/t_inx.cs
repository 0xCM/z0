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
        /// <summary>
        /// Asserts the equality of two bitspans
        /// </summary>
        /// <param name="a">The left bitspan</param>
        /// <param name="b">The right bitspan</param>
        protected void ClaimEqual(in BitSpan a, in BitSpan b)
        {
            if(a != b)
            {
                Trace(a.Format());
                Trace(b.Format());
                Claim.fail();
            }
        }
    }
}