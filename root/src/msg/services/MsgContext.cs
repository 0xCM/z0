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
        readonly IAppMsgQueue Queue;

        /// <summary>
        /// Creates a message context that manages its own queue
        /// </summary>
        /// <param name="queue">The target queue</param>
        public static IMsgContext Create(IAppMsgQueue dst)
            => new MsgContext(dst);          

        public static IMsgContext Create()
            => new MsgContext();

        MsgContext(IAppMsgQueue dst)
            => Queue = dst;

        MsgContext()
            => Queue = MsgContextQueue.Create(this);

        public IReadOnlyList<AppMsg> Dequeue()
            => Queue.Dequeue();

        /// <summary>
        /// Enqueues application messages
        /// </summary>
        /// <param name="msg">The messages to enqueue</param>
        [MethodImpl(Inline)]
        public void Enqueue(AppMsg msg)
            => Queue.Enqueue(msg);
        
        [MethodImpl(Inline)]
        public void Enqueue(string msg, AppMsgKind? severity = null)
            => Queue.Enqueue(msg,severity);

        public void Flush(Exception e, IAppMsgLog target)
        {
            target.Write(Flush(e));
        }

        public IReadOnlyList<AppMsg> Flush(Exception e)        
        {
            var messages = Queue.Flush(e);            
            Terminal.Get().WriteMessages(messages);
            return messages;
        }
    }    
}