//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    class BinaryOpComparer<T> : BinaryFuncComparer<T,T,T>, IBinaryOpComparer<T>
        where T : unmanaged
    {
        public BinaryOpComparer(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

        public BinaryOpComparer(IComparisonContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

    }


}