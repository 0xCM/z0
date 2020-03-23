//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    class BinaryPredicateComparer<T> : BinaryFuncComparer<T,T,bit>, ISFApiBinaryPredicateComparer<T>
        where T : unmanaged
    {
        public BinaryPredicateComparer(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

        public BinaryPredicateComparer(IValidationContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }
    }    
}