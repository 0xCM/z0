//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes an F-bound polymorphic reifiable abstraction
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    public interface IReified<F>
        where F : IReified<F>, new()
    {

    }    
}