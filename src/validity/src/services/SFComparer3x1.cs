//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    class STernaryPredMatch<T> : SFMatch<T,T,T,bit>, ISFMatch<T,T,T,bit>
        where T : unmanaged
    {
        public STernaryPredMatch(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

    }    
}