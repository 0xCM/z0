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
    
    using static zfunc;

    public class MsgContext : Context, IMsgContext
    {
        protected MsgContext()
        {
            this.Queue = AppMsgQueue.Create();
        }

        AppMsgQueue Queue;

        object lockobj = new object();

        public IReadOnlyList<AppMsg> DequeuePosts()
        {
            lock(lockobj)
                return Queue.Dequeue();
        }
        
        /// <summary>
        /// Enqueues application messages
        /// </summary>
        /// <param name="msg">The messages to enqueue</param>
        public void PostMessage(AppMsg msg)
        {
            lock(lockobj)
                Queue.Post(msg);
        }

        public void PostError(Exception e)
        {
            IReadOnlyList<AppMsg> messages = default;
            lock(lockobj)
            {
                Queue.Post(AppMsg.Define($"{e}", SeverityLevel.Error));
                messages = Queue.Dequeue();
            }
            
            Terminal.Get().WriteMessages(messages);
            log(messages, LogArea.Test);            
        }
        
        public void PostMessage(string msg, SeverityLevel? severity = null)
        {
            lock(lockobj)                
                Queue.Post(msg,severity);
        }               
    }    
}