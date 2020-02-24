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
    
    public sealed class MsgContext : IMsgContext
    {
        readonly AppMsgQueue Queue;

        public static IMsgContext Create()
            => new MsgContext();          

        MsgContext()
            => Queue = AppMsgQueue.Create();

        public IReadOnlyList<AppMsg> DequeuePosts()
            => Queue.Dequeue();
        
        /// <summary>
        /// Enqueues application messages
        /// </summary>
        /// <param name="msg">The messages to enqueue</param>
        public void PostMessage(AppMsg msg)
            => Queue.Post(msg);

        public void Flush(Exception e, IMsgLog target)
        {
            var messages = Queue.Flush(e);            
            Terminal.Get().WriteMessages(messages);
            target.Write(messages);

        }
        
        public void PostMessage(string msg, SeverityLevel? severity = null)
            => Queue.Post(msg,severity);
    }    
}