//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;

    public interface IRngProvider<R>
        where R : IPolySource
    {
        /// <summary>
        /// The provided random source
        /// </summary>
        R Random {get;}
    }

    /// <summary>
    /// Characterizes a type that provides access to a stateful and parametric-polymorphic 
    /// pseudorandom number generator
    /// </summary>
    public interface IPolyrandProvider : IRngProvider<IPolyrand>
    {

    }
}