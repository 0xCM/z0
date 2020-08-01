//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    public interface ICommandCompletion : ICommandDispatch
    {
        DateTime CompleteTime { get; }

        bool Succeeded { get; }

        string CompleteMessage { get; }

        ICommandResult Result { get; }
    }

    public interface ICommandCompletion<S> : ICommandDispatch<S>, ICommandCompletion
        where S : CommandSpec<S>, new()
    {
        new ICommandResult<S> Result { get; }
    }


    public interface ICommandCompletion<S,P> : ICommandCompletion<S>
        where S : CommandSpec<S,P>, new()
    {
        new ICommandResult<S,P> Result { get; }
    }
}