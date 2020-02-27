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
    public interface IAppMsgExchange
    {
        /// <summary>
        /// Removes the messages accumulated by the context and returns these messages to the caller
        /// </summary>
        IReadOnlyList<AppMsg> DequeuePosts();

        /// <summary>
        /// Posts a message to the context queue
        /// </summary>
        /// <param name="msg">The message to post</param>
        void PostMessage(AppMsg msg);

        /// <summary>
        /// Posts a text message to the context queue with optional severity
        /// </summary>
        /// <param name="msg">The message to post</param>
        void PostMessage(string msg, AppMsgKind? severity = null);

        void Flush(Exception exception, IAppMsgLog target);                       
    }
}