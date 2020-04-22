//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    class CheckTernaryOpSF<T> : CheckSF3<T,T,T,T>, ICheckSF<T,T,T,T>
        where T : unmanaged
    {
        public CheckTernaryOpSF(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

    }
}