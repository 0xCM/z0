//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using static z;

    public class CommandDispatch<S> : CommandSubmission<S>, ICommandDispatch<S>
        where S : CommandSpec<S>, new()
    {
        readonly DateTime Timestamp;

        public CommandDispatch(ICommandDispatch src)
            : this(new CommandDispatch(src))
        { }

        public CommandDispatch(CommandDispatch src)
            : base(new CommandSubmission<S>((S)src.Spec, src.SubmissionId, src.CommandJson, src.CorrelationToken, src.EnqueuedTime))
        {
            Timestamp = src.DispatchTime;
        }

        public CommandDispatch(CommandSubmission<S> src, DateTime? ts = null)
            : base(src)
        {
            Timestamp = ts ?? now();
        }

        public CommandDispatch(CommandDispatch<S> src)
            : base(src)
        {
            Timestamp = src.Timestamp;
        }

        public DateTime DispatchTime
            => Timestamp;

        public override CommandExecutionStatus Status
            => CommandExecutionStatus.Dispatched;
    }

    public class CommandDispatch : CommandSubmission, ICommandDispatch
    {
        readonly DateTime Timestamp;

        public static ICommandDispatch Create(CommandSubmission submission, DateTime? ts = null)
            => new CommandDispatch(submission, ts);

        public static CommandDispatch<S> Create<S>(CommandSubmission<S> submission, DateTime? ts = null)
                where S : CommandSpec<S>, new()
                    => new CommandDispatch<S>(submission, ts);

        public CommandDispatch(ICommandSubmission src, DateTime? ts = null)
            : base(src)
        {
            Timestamp = ts ?? now();
        }

        public CommandDispatch(ICommandDispatch src)
            : base(src)
        {
            Timestamp = src.DispatchTime;
        }

        public DateTime DispatchTime
            => Timestamp;

        public override CommandExecutionStatus Status
            => CommandExecutionStatus.Dispatched;
    }
}