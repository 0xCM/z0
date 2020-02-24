//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    
    public abstract class OpContext<C> : RngContext<C>, IRngContext<C>
        where C : OpContext<C>
    {                
        protected OpContext(IPolyrand random)
            : base(random)            
        {

        }
    }   
}