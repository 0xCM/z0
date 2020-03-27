//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    class SFOpMatch3<T> : SFMatch<T,T,T,T>, ISFMatch<T,T,T,T>
        where T : unmanaged
    {
        public SFOpMatch3(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

    }
}