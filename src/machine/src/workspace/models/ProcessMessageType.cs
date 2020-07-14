//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    /// <summary>
    /// Partitions prompt messsages into equivalence classes
    /// </summary>
    public enum ProcessMessageType
    {
        /// <summary>
        /// No category has ben assigned
        /// </summary>
        None,

        /// <summary>
        /// The message defines a commmand
        /// </summary>
        Command,

        /// <summary>
        /// The message is accumulated from a sequence of packets received
        /// from the standard output stream
        /// </summary>
        Ok,

        /// <summary>
        /// The message is accumulated from a sequence of packets received
        /// from the error output stream
        /// </summary>
        Error,

        SystemError_
    }
}