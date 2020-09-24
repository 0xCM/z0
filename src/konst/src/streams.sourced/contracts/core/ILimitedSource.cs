//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes an emission service that may run out of values to emit
    /// </summary>
    /// <typeparam name="T">The emission value type</typeparam>
    [Free]
    public interface ILimitedSource<T>
    {
        /// <summary>
        /// Populates the target with the next value if it exists
        /// </summary>
        bool Next(out T dst);
    }
}