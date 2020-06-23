//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    /// <summary>
    /// Base type for intrinsic tests
    /// </summary>
    /// <typeparam name="X">The concrete subtype</typeparam>
    public abstract class t_inx<X> : UnitTest<X, CheckIntrinsics, TCheckInstrinsics>
        where X : t_inx<X>
    {
        protected t_inx()
        {
            CheckSVF  =   Context.CheckSVF();
        }
        
        protected readonly ICheckSVF CheckSVF;        
    }   
}