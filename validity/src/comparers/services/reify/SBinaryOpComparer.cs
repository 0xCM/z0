//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    class SBinaryOpComparer<T> : SFComparer<T,T,T>, ISFMatch<T,T,T>
        where T : unmanaged
    {
        public SBinaryOpComparer(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

        public SBinaryOpComparer(IValidationContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }
    }
}