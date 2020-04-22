//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public abstract class OperatorComparer<W,T> : SFMatch
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        protected OperatorComparer(ITestContext context, bool xzero = false)
            : base(context,xzero)        
        {
            
        }
    }
}