//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    class CheckTernaryPredSF<T> : CheckSF3<T,T,T,bit>, ICheckSF<T,T,T,bit>
        where T : unmanaged
    {
        public CheckTernaryPredSF(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }
    }    
}