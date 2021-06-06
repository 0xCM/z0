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
        dynamic Position => 0u;
    }

    [Free]
    public interface IPositioned<T> : IPositioned
        where T : unmanaged
    {
        /// <summary>
        /// The 0-based position of the item in an enclosing container
        /// </summary>
        new T Position {get;}

        dynamic IPositioned.Position
            => Position;
    }
}