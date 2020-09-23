//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Security;

    /// <summary>
    /// Characterizes a random stream navigator
    /// </summary>
    public interface IRngNav
    {
        /// <summary>
        /// Moves the stream a specified number of steps forward
        /// </summary>
        /// <param name="steps">The step count</param>
        void Advance(ulong steps);

        /// <summary>
        /// Moves the stream a specified number of steps backward
        /// </summary>
        /// <param name="steps">The step count</param>
        void Retreat(ulong steps);
    }

    /// <summary>
    /// Characterizes a random source that can be navigated
    /// </summary>
    /// <typeparam name="T">The primal element type</typeparam>
    public interface IRngNav<T> : IRngNav, IRngBoundPointSource<T>
        where T : struct
    {

    }
}