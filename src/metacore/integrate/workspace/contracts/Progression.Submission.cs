//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    public interface ICommandSubmission : ICommandProgression
    {
        long SubmissionId { get; }

        DateTime EnqueuedTime { get; }
    }

    public interface ICommandSubmission<S> : ICommandProgression<S>, ICommandSubmission
        where S : CommandSpec<S>, new()
    {

    }
}