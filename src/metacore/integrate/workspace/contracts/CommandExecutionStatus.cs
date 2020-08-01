//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    /// <summary>
    /// Enumerates the potential command execution states
    /// </summary>
    public enum CommandExecutionStatus
    {
        /// <summary>
        /// Indicates the lack of status
        /// </summary>
        None = 0,

        /// <summary>
        /// The command has been submitted and is ready for dispatch
        /// </summary>
        Submitted = 1,

        /// <summary>
        /// The command is on route to, or in the embrace of, an executor
        /// </summary>
        Dispatched = 2,

        /// <summary>
        /// The command has completed execution
        /// </summary>
        Completed = 3
    }
}