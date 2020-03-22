//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    class TernaryOpComparer<T> : TernaryFuncComparer<T,T,T,T>, ITernaryOpComparer<T>
        where T : unmanaged
    {
        public TernaryOpComparer(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

        public TernaryOpComparer(IComparisonContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

    }
}