//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public abstract class Context<T> : Context
        where T : Context<T>
    {                
        protected Context(IPolyrand random)
            : base(random)            
        {

        }
    }       
}