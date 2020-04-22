//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    class CheckSF1<T,R> : CheckSF, ICheckSF<T,R>
        where T : unmanaged
        where R : unmanaged
    {
        public CheckSF1(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {

        }
    }
}