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

    public sealed class CommandResult<S> : ICommandResult<S>
        where S : CommandSpec<S>, new()
    {
        public S Spec { get; private set; }

        public object Payload { get; private set;}

        public bool Succeeded { get; private set;}

        public IAppMsg Message { get; private set;}

        public long SubmissionId { get; private set;}

        public CorrelationToken? CorrelationToken { get; private set;}

        public static implicit operator CommandResult(CommandResult<S> result)
            => result.Degrade();

        public CommandResult(ICommandResult src)
        {
            Spec = (S)src.Spec;
            Payload = src.Payload;
            Succeeded = src.Succeeded;
            Message = src.Message;
            SubmissionId = src.SubmissionId;
            CorrelationToken = src.CorrelationToken;
        }

        public CommandResult(S spec, object payload, bool succeeded, IAppMsg message, long subid, CorrelationToken? ct = null)
        {
            Spec = spec;
            Payload = payload;
            Succeeded = succeeded;
            Message = message;
            SubmissionId = subid;
            CorrelationToken = ct;
        }

        object ICommandResult.Payload 
            => Payload;

        ICommandSpec ICommandResult.Spec 
            => Spec;

        public CommandResult Degrade()
            => new CommandResult(Spec, Payload, Succeeded, Message, SubmissionId, CorrelationToken);
    }
}