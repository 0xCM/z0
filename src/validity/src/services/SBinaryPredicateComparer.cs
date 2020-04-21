//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    class SBinaryPredMatch<T> : SFComparer<T,T,bit>, ISFMatch<T,T,bit>
        where T : unmanaged
    {
        public SBinaryPredMatch(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }
    }    
}