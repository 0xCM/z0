//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a lightweight, perhaps not-so-safe, "SafeHandle"
    /// </summary>
    public interface IHandle
    {
        /// <summary>
        /// The handle address
        /// </summary>
        MemoryAddress Address {get;}

        /// <summary>
        /// Specifies whether the instance is responsible for handle lifecycle management
        /// </summary>
        bool IsOwner {get;}

    }

    /// <summary>
    /// Characterizes a <see cref='IHandle'/> reification
    /// </summary>
    /// <typeparam name="T">The reifying type</typeparam>
    public interface IHandle<T> : IHandle
        where T : struct, IHandle<T>
    {

    }
}