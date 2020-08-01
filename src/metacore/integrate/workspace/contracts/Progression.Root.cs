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

    public interface ICommandProgression<S> : ICommandProgression
        where S : CommandSpec<S>, new()
    {
        new S Spec { get; }

    }
}