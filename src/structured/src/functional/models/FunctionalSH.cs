//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Reifies a functional service factory with an H-parametric enclosure
    /// </summary>
    /// <typeparam name="F">The factory type</typeparam>
    /// <typeparam name="H">The host enclosure type</typeparam>
    public readonly struct Functional<S,H> : IFunctional<S,H>
        where S : IFunctional<S,H>, new()
    {

        
    }
}