//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IAsmWorkflow<R> :  IAppMsgReceiver, IStepBrokerProvider<R>
        where R : IStepBroker
    {

    }

    public interface IAsmWorkflow<W,R> : IAsmWorkflow<R>
        where W : IAsmWorkflow<W,R>
        where R : IStepBroker
    {

    }
}