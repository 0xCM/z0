//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    class CheckBinaryOpSF<T> : CheckSF2<T,T,T>, ICheckSF<T,T,T>
        where T : unmanaged
    {
        public CheckBinaryOpSF(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }
    }
}