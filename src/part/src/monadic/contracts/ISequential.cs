//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
 
    /// <summary>
    /// Characterizes an individual that can be identified, relative to other
    /// sequentials (within the same set), by a term s(i) of a monotonic sequence 
    /// s = {0,..,n - 1} where s(i) = i
    /// </summary>
    public interface ISequential
    {
        /// <summary>
        /// The sequence number assigned to the individual
        /// </summary>
        int Sequence {get;}
    }
}