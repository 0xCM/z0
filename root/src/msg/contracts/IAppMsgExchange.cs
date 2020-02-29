//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes a stateful thing that functions as an exchange for application messages
    /// </summary>
    public interface IAppMsgExchange : IAppMsgSink
    {
        /// <summary>
        /// Removes the messages accumulated by the context and returns these messages to the caller
        /// </summary>
        IReadOnlyList<AppMsg> DequeueMessages();

        void FlushMessages(Exception exception, IAppMsgLog target);                       
    }
}