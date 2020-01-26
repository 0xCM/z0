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

    public interface IOpContext : IContext
    {
        
    }
    public abstract class OpContext<T> : Context<T>, IOpContext
        where T : OpContext<T>
    {                
        protected OpContext(IPolyrand random)
            : base(random)            
        {

        }
    }   
}