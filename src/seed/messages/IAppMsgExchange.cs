//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a stateful thing that functions as an exchange for application messages
    /// </summary>
    public interface IAppMsgExchange : IAppMsgQueue
    {        
        void Flush(Exception exception, IAppMsgSink target);                       
    }
}