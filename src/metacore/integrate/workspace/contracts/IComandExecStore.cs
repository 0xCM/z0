//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static z;

    /// <summary>
    /// Defines contract for command execution queue repository
    /// </summary>
    public interface ICommandExecStore : ICommandSubmitter
    {
        Option<CommandDispatch<S>> Dispatch<S>()
            where S : CommandSpec<S>, new();

        Option<CommandDispatch<TSpSc>[]> Dispatch<TSpSc>(int MaxCount)
            where TSpSc : CommandSpec<TSpSc>, new();

        Option<ICommandDispatch[]> Dispatch(int MaxCount);

        Option<ICommandCompletion[]> Complete(IEnumerable<ICommandResult> results);

        Option<ICommandCompletion> Complete(ICommandResult result);    

        Option<CommandCompletion<S,P>[]> Complete<S,P> (IEnumerable<CommandResult<S,P>> results) 
            where S : CommandSpec<S,P>, new();

        Option<CommandCompletion<S>> Complete<S>(CommandResult<S> result) 
            where S : CommandSpec<S>, new();

        Option<CommandCompletion<S,P>> Complete<S,P> (CommandResult<S,P> result) 
            where S : CommandSpec<S,P>, new();

        Option<int> GetCurrentSubmissionCount();

        Option<int> PurgeSubmissions(Option<CommandName> CommandName);

        Option<int> PurgeDispatches(Option<CommandName> CommandName);

        Option<int> PurgeCompletions(Option<CommandName> CommandName);

        /// <summary>
        /// Purges the queues for a specific command, if supplied. Otherwise, purges all queues
        /// </summary>
        /// <param name="CommandName">The name of the command for which the queues will be purged</param>
        /// <returns></returns>
        Option<int> PurgeQueues(Option<CommandName> CommandName);
    }
}