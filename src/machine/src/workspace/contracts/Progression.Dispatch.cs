//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    public interface ICommandDispatch : ICommandSubmission
    {
        DateTime DispatchTime { get; }
    }

    public interface ICommandDispatch<S> : ICommandSubmission<S>, ICommandDispatch
        where S : CommandSpec<S>, new()
    {

    }
}