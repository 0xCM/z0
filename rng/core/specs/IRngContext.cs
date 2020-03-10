//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;

   /// <summary>
    /// Characterizes a type that provides access to a stateful and parametric-polymorphic 
    /// pseudorandom number generator
    /// </summary>
    public interface IRngProvider
    {
        /// <summary>
        /// The provided random number generator
        /// </summary>
        IPolyrand Random {get;}
        
    }
    
    /// <summary>
    /// A context that carries an RNG state
    /// </summary>
    public interface IRngContext : IRngProvider, IContext
    {   
           
    }

    public readonly struct RngContext<R> : IRngContext, IRootedContext<R>
        where R : IContext
    {
        public R Root {get;}

        public IPolyrand Random {get;}

        public RngContext(R root, IPolyrand rng)
        {
            this.Root = root;
            this.Random = rng;
        }
    }
}