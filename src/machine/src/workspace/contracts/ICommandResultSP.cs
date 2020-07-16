//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    /// <summary>
    /// Defines contract for command results, generic with respect to specification and payload
    /// </summary>
    public interface ICommandResult<out S, out P> : ICommandResult<S>
        where S : CommandSpec<S, P>, new()
    {
        /// <summary>
        /// The value computed by the command when executed, if successful
        /// </summary>
        new P Payload { get; }
    }
}