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
    
    public abstract class RngContext : IRngContext
    {                
        protected RngContext(IPolyrand rng)
        {
            this.Random = rng;            
        }

        /// <summary>
        /// The context random source
        /// </summary>
        public virtual IPolyrand Random {get;}        

    }

    public abstract class RngContext<C> : RngContext, IRngContext<C>
        where C : RngContext<C>
    {                
        protected RngContext(IPolyrand random)
            : base(random)            
        {

        }
    }           
}