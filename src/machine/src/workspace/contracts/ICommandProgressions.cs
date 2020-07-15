//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    public interface ICommandProgression
    {
        CommandExecutionStatus Status { get; }

        ICommandSpec Spec { get; }

        string CommandJson { get; }

        CommandName CommandName { get; }

        CorrelationToken? CorrelationToken { get; }
    }

    public interface ICommandProgression<TSpec> : ICommandProgression
        where TSpec : CommandSpec<TSpec>, new()
    {
        new TSpec Spec { get; }

    }

    public interface ICommandSubmission : ICommandProgression
    {
        long SubmissionId { get; }
        DateTime EnqueuedTime { get; }

    }

    public interface ICommandSubmission<TSpec> : ICommandProgression<TSpec>, ICommandSubmission
        where TSpec : CommandSpec<TSpec>, new()
    {

    }

    public interface ICommandDispatch : ICommandSubmission
    {
        DateTime DispatchTime { get; }
    }

    public interface ICommandDispatch<TSpec> : ICommandSubmission<TSpec>, ICommandDispatch
        where TSpec : CommandSpec<TSpec>, new()
    {

    }


    public interface ICommandCompletion : ICommandDispatch
    {
        DateTime CompleteTime { get; }

        bool Succeeded { get; }

        string CompleteMessage { get; }

        ICommandResult Result { get; }
    }

    public interface ICommandCompletion<TSpec> : ICommandDispatch<TSpec>, ICommandCompletion
        where TSpec : CommandSpec<TSpec>, new()
    {
        new ICommandResult<TSpec> Result { get; }
    }


    public interface ICommandCompletion<TSpec, TPayload> : ICommandCompletion<TSpec>
        where TSpec : CommandSpec<TSpec, TPayload>, new()
    {
        new ICommandResult<TSpec, TPayload> Result { get; }
    }
}