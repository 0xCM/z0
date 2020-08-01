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

    public class CommandCompletion<S> : CommandDispatch<S>, ICommandCompletion<S>
        where S : CommandSpec<S>, new()
    {
        readonly DateTime Timestamp;

        public DateTime CompleteTime
            => Timestamp;

        public CommandResult<S> Result { get; }

        public CommandCompletion(ICommandDispatch src, ICommandResult result, DateTime? ts = null)
            : base(src)
        {
            Result = new CommandResult<S>(result);
            Timestamp = ts ?? now();
        }

        public CommandCompletion(CommandDispatch<S> src, CommandResult<S> result, DateTime? ts = null)
            : base(src)
        {
            Result = result;
            Timestamp = ts ?? now();
        }

        public bool Succeeded
            => Result.Succeeded;

        public string CompleteMessage
            => Result.Message.Format();

        public override CommandExecutionStatus Status
            => CommandExecutionStatus.Completed;

        ICommandResult ICommandCompletion.Result
            => Result;

        ICommandResult<S> ICommandCompletion<S>.Result
            => Result;
    }


    public class CommandCompletion<S,P> : CommandCompletion<S>, ICommandCompletion<S,P>
        where S : CommandSpec<S,P>, new()
    {
        public new CommandResult<S,P> Result { get; }

        public CommandCompletion(CommandDispatch<S> src, CommandResult<S,P> result, DateTime? ts = null)
            : base(src, result, ts)
        {
            Result = result;
        }

        ICommandResult<S,P> ICommandCompletion<S,P>.Result
            => Result;
    }
}