//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    class CheckUnaryOpSF<T> : CheckSF1<T,T>, ICheckSF<T,T>
        where T : unmanaged
    {
        public CheckUnaryOpSF(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }
    }
}