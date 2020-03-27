//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    class SFOpMatch1<T> : SFOpMatch<T,T>, ISFMatch<T,T>
        where T : unmanaged
    {
        public SFOpMatch1(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }
    }
}