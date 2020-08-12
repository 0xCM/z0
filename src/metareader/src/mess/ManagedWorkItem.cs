//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// A managed threadpool object.
    /// </summary>
    public abstract class ManagedWorkItem
    {
        /// <summary>
        /// Gets the object address of this entry.
        /// </summary>
        public abstract ulong Object { get; }

        /// <summary>
        /// Gets the type of Object.
        /// </summary>
        public abstract ClrType Type { get; }
    }                
}