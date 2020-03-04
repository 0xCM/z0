//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using static Root;
    public interface IAppMsgQueue : ISink<AppMsg>
    {
        /// <summary>
        /// Posts a message to the context queue
        /// </summary>
        /// <param name="msg">The message to post</param>
        void Enqueue(AppMsg msg);        

        /// <summary>
        /// Posts an arbitrary number of messages to the queue
        /// </summary>
        /// <param name="msg">The message to post</param>
        void Enqueue(IEnumerable<AppMsg> msg)
            => iter(msg,Enqueue);        

        void ISink<AppMsg>.Accept(in AppMsg src)
            => Enqueue(src);

        /// <summary>
        /// Posts a text message to the context queue with optional severity
        /// </summary>
        /// <param name="msg">The message to post</param>
        void Enqueue(string msg, AppMsgKind? severity = null);

        IReadOnlyList<AppMsg> Dequeue();        

        IReadOnlyList<AppMsg> Flush(Exception e);
    }
}