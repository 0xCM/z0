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
    public interface IPolyrandProvider
    {
        /// <summary>
        /// The provided random number generator
        /// </summary>
        IPolyrand Random {get;}        
    }
}