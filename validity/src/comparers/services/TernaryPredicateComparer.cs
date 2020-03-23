//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    class TernaryPredicateComparer<T> : TernaryFuncComparer<T,T,T,bit>, ITernaryPredicateComparer<T>
        where T : unmanaged
    {
        public TernaryPredicateComparer(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

        public TernaryPredicateComparer(IValidationContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

    }    

}