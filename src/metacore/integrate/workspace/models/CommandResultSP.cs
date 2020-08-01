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

    public sealed class CommandResult<S,P> : ICommandResult<S,P>
        where S : CommandSpec<S,P>, new()
    {
        public S Spec { get; private set; }

        public P Payload { get; private set; }

        public bool Succeeded { get; private set; }

        public IAppMsg Message { get; private set; }

        public long SubmissionId { get; private set; }

        public CorrelationToken? CorrelationToken { get; private set; }

        public static implicit operator CommandResult(CommandResult<S,P> result)
            => result.Degrade();

        public static implicit operator CommandResult<S>(CommandResult<S, P> result)
            => result.Degrade();

        public CommandResult(S spec, P payload, bool succeeded, IAppMsg message, long subid, CorrelationToken? ct = null)
        {
            Spec = spec;
            Payload = payload;
            Succeeded = succeeded;
            Message = message ?? AppMsg.Empty;
            SubmissionId = subid;
            CorrelationToken = ct;
        }

        object ICommandResult.Payload 
            => Payload;

        ICommandSpec ICommandResult.Spec 
            => Spec;

        public CommandResult<S> Degrade()
            => new CommandResult<S>(Spec, Payload, Succeeded, Message, SubmissionId, CorrelationToken);
    }
}