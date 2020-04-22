//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;

    /// <summary>
    /// Joines a sink and receiver to form a context
    /// </summary>
    public interface IAppMsgContext : IAppMsgSink, IAppMsgReceiver
    {
        IAppMsgSink IAppMsgReceiver.Sink => this;        
    }
}