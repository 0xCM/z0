//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    /// <summary>
    /// The type of frame the ClrStackFrame represents.
    /// </summary>
    public enum ClrStackFrameKind
    {
        /// <summary>
        /// Indicates this stack frame is unknown
        /// </summary>
        Unknown = -1,

        /// <summary>
        /// Indicates this stack frame is a standard managed method.
        /// </summary>
        ManagedMethod = 0,

        /// <summary>
        /// Indicates this stack frame is a special stack marker that the CLR leaves on the stack.
        /// Note that the <see cref="ClrStackFrame"/> may still have a <see cref="ClrMethod"/> associated with the marker.
        /// </summary>
        Runtime = 1
    }
}