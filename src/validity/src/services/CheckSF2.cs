//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;
    using static Memories;
    using static Structured;


    class CheckSF2<T0,T1,R> : CheckSF, ICheckSF<T0,T1,R>
        where T0 : unmanaged
        where T1 : unmanaged
        where R : unmanaged
    {
        public CheckSF2(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

    }
}