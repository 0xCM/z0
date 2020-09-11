//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public abstract class t_vcheck<X> : UnitTest<X, CheckIntrinsics, TCheckIntrinsics>
        where X : t_vcheck<X>
    {
        protected t_vcheck()
        {
            CheckSVF  =   Context.CheckSVF();
        }

        protected readonly ICheckSVF CheckSVF;
    }
}