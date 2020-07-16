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

    public sealed class CommandResult : ICommandResult
    {
        public long SubmissionId { get; private set;}

        public CorrelationToken? CorrelationToken { get; private set;}

        /// <summary>
        /// The value that represents or otherwise identifies the result computed by the command
        /// </summary>
        public object Payload { get; private set;}

        /// <summary>
        /// Specifies whether the command successfully executed which, by definition, means that
        /// a payload was successfully computed
        /// </summary>
        public bool Succeeded { get; private set;}

        public ICommandSpec Spec { get; private set;}

        public IAppMsg Message { get; private set;}

        public static CommandResult Failure(ICommandSpec spec, IAppMsg message = null, long? subid = null, CorrelationToken? ct = null)
            => new CommandResult(spec, null, false, message, subid ?? 0, ct);

        public static CommandResult<S,P> Failure<S,P>(S spec, IAppMsg message = null, long? subid = null, CorrelationToken? ct = null)
            where S : CommandSpec<S,P>, new()
                => new CommandResult<S,P>(spec, default, false, message, subid ?? 0, ct);

        public static CommandResult FromOption<S,R>(S spec, Option<R> result)
            where S : CommandSpec<S>, new()
                => throw new NotImplementedException();
                
        public CommandResult(ICommandSpec spec, object payload, bool succeeded, IAppMsg message = null, long subid = 0, CorrelationToken? ct = null)
        {
            Spec = spec;
            Payload = payload;
            Succeeded = succeeded;
            SubmissionId = subid;
            CorrelationToken = ct;
            Message = message ??
                (
                    succeeded 
                    ? CommandStatusMessages.CommandSucceeded(this)
                    : CommandStatusMessages.CommandFailed(this)
                );
        }

        public string CommandName
            => Spec.CommandName;

        public string CommandSpecName
            => Spec.SpecName;

        public override string ToString()
            => $"{CommandName} command " + (Succeeded 
                ? "succeeded" : "failed") + $": {Message}";
    }
}