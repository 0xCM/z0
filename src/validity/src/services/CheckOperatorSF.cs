//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public abstract class CheckOperatorSF<W,T> : CheckSF
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        protected CheckOperatorSF(ITestContext context, bool xzero = false)
            : base(context,xzero)        
        {
            
        }
    }
}