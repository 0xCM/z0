//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public interface IAppMsgSink : ISink<AppMsg>
    {
        /// <summary>
        /// Posts a message to the context queue
        /// </summary>
        /// <param name="msg">The message to post</param>
        void PostMessage(AppMsg msg);        

        void ISink<AppMsg>.Accept(in AppMsg src)
            => PostMessage(src);

        /// <summary>
        /// Posts a text message to the context queue with optional severity
        /// </summary>
        /// <param name="msg">The message to post</param>
        void PostMessage(string msg, AppMsgKind? severity = null);
    }
}