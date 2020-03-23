//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    class UnaryOpComparer<T> : UnaryFuncComparer<T,T>, ISFApiUnaryOpComparer<T>
        where T : unmanaged
    {
        public UnaryOpComparer(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

        public UnaryOpComparer(IValidationContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }
    }
}