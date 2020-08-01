//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    /// <summary>
    /// Defines contract for command results, generic with respect to specification
    /// </summary>
    public interface ICommandResult<out S> : ICommandResult
        where S : CommandSpec<S>, new()
    {
        /// <summary>
        /// The value computed by the command when executed, if successful
        /// </summary>
        new S Spec { get; }
    }
}