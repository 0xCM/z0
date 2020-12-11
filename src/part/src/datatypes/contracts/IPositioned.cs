//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes an individual that can be uniquely associated with an integer in the range 0..n-1
    /// within the context of a container with a capacity of n items
    /// </summary>
    [Free]
    public interface IPositioned
    {
        /// <summary>
        /// The 0-based position of the item in an enclosing container
        /// </summary>
        int Position {get;}
    }

    [Free]
    public interface IPositioned<F> : IPositioned
        where F : IPositioned<F>, new()
    {

    }
}