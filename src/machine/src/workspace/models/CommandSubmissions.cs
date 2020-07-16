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

    public class CommandSubmission<S> : CommandProgression<S>, ICommandSubmission<S>
        where S : CommandSpec<S>, new()
    {
        readonly long SubId;
        
        readonly DateTime Timestamp;

        public CommandSubmission(ICommandSubmission src)
            : base(src)
        {
            SubId = src.SubmissionId;
            Timestamp = src.EnqueuedTime;
        }

        public CommandSubmission(CommandSubmission<S> src)
            : base(src)
        {
            SubId = src.SubId;
            Timestamp = src.Timestamp;
        }

        public CommandSubmission(S spec, long subid, string json, CorrelationToken? ct = null, DateTime? ts = null)
            : base(spec, json, ct)
        {
            SubId = subid;
            Timestamp = ts ?? now();
        }

        public long SubmissionId
            => SubId;

        public DateTime EnqueuedTime
            => Timestamp;

        public override CommandExecutionStatus Status
            => CommandExecutionStatus.Submitted;
    }

    public class CommandSubmission : CommandProgression, ICommandSubmission
    {
        readonly long SubId;
     
        readonly DateTime Timestamp;

        /// <summary>
        /// Submission constructor function
        /// </summary>
        /// <typeparam name="S">The command type</typeparam>
        /// <param name="spec">The command</param>
        /// <param name="subid">The submission id</param>
        /// <param name="json">The comand body formatted as json</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="ts">The submission timestamp</param>
        public static CommandSubmission<S> Create<S>(S spec, long subid, string json, CorrelationToken? ct = null, DateTime? ts = null)
            where S : CommandSpec<S>, new()
                => new CommandSubmission<S>(spec, subid, json, ct, ts ?? now());

        public CommandSubmission(ICommandSubmission src)
            : base(src)
        {
            SubId = src.SubmissionId;
            Timestamp = src.EnqueuedTime;
        }

        public CommandSubmission(CommandSubmission src)
            : base(src)
        {
            SubId = src.SubId;
            Timestamp = src.Timestamp;
        }

        public CommandSubmission(ICommandSpec spec, long subid, string json, CorrelationToken? ct = null, DateTime? ts = null)
            : base(spec, json, ct)
        {
            SubId = subid;
            Timestamp = ts ?? now();
        }

        public long SubmissionId
            => SubId;

        public DateTime EnqueuedTime
            => Timestamp;

        public override CommandExecutionStatus Status
            => CommandExecutionStatus.Submitted;
    }
}