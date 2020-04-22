//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    class CheckBinaryPredSF<T> : CheckSF2<T,T,bit>, ICheckSF<T,T,bit>
        where T : unmanaged
    {
        public CheckBinaryPredSF(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }
    }    
}