//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    /// <summary>
    /// Defines contract for non-generic command execution result values
    /// </summary>
    public interface ICommandResult
    {
        /// <summary>
        /// The specification that was executed
        /// </summary>
        ICommandSpec Spec { get; }

        /// <summary>
        /// The value computed by the command when executed, if successful
        /// </summary>
        object Payload { get; }

        /// <summary>
        /// Specifies whether the command executed successfully
        /// </summary>
        bool Succeeded { get; }

        /// <summary>
        /// A message describing the command execution outcome
        /// </summary>
        IAppMsg Message { get; }

        /// <summary>
        /// The identifier that was assigned when the command was submitted for execution
        /// </summary>
        long SubmissionId { get; }

        /// <summary>
        /// The correlation token, if any, that allows the represented execution to be
        /// associated with other command executions
        /// </summary>
        CorrelationToken? CorrelationToken { get; }
    }
}