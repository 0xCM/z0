//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public sealed class MsgContext : IMsgContext
    {
        readonly MsgContextQueue Queue;

        /// <summary>
        /// Creates a message context that manages its own queue
        /// </summary>
        /// <param name="queue">The target queue</param>
        public static IMsgContext Create()
            => new MsgContext();          

        /// <summary>
        /// Creates a message context using a supplied target queue
        /// </summary>
        /// <param name="queue">The target queue</param>
        public static IMsgContext Create(MsgContextQueue queue)
            => new MsgContext(queue);          

        MsgContext()
            => Queue = MsgContextQueue.Create();

        MsgContext(MsgContextQueue queue)
            => Queue = queue;

        public IReadOnlyList<AppMsg> DequeueMessages()
            => Queue.Dequeue();
        
        /// <summary>
        /// Enqueues application messages
        /// </summary>
        /// <param name="msg">The messages to enqueue</param>
        [MethodImpl(Inline)]
        public void PostMessage(AppMsg msg)
            => Queue.PostMessage(msg);
        
        [MethodImpl(Inline)]
        public void PostMessage(string msg, AppMsgKind? severity = null)
            => Queue.PostMessage(msg,severity);

        public void FlushMessages(Exception e, IAppMsgLog target)
        {
            var messages = Queue.Flush(e);            
            Terminal.Get().WriteMessages(messages);
            target.Write(messages);
        }
    }    
}