//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Reifies a functional service factory that also serves as a host enclosure
    /// </summary>
    /// <typeparam name="F">The factory type</typeparam>
    public readonly struct Functional<F> : IFunctional<F>
        where F : IFunctional<F>, new()
    {


    }
}