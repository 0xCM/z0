//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    class CheckSF3<T0,T1,T2,R> : CheckSF, ICheckSF<T0,T1,T2,R>
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where R : unmanaged
    {
        public CheckSF3(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

    }
}