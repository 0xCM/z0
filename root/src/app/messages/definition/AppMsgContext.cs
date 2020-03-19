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

    public sealed class AppMsgContext : IAppMsgContext
    {
        readonly IAppMsgQueue Queue;

        /// <summary>
        /// Creates a message context that manages its own queue
        /// </summary>
        /// <param name="queue">The target queue</param>
        public static IAppMsgContext Create(IAppMsgQueue dst)
            => new AppMsgContext(dst);          

        public static IAppMsgContext Create()
            => new AppMsgContext();

        AppMsgContext(IAppMsgQueue dst)
            => Queue = dst;

        AppMsgContext()
            => Queue = AppMsgQueue.Create();

        public IReadOnlyList<AppMsg> Flush()
            => Queue.Flush();

        /// <summary>
        /// Enqueues application messages
        /// </summary>
        /// <param name="msg">The messages to enqueue</param>
        [MethodImpl(Inline)]
        public void Notify(AppMsg msg)
            => Queue.Notify(msg);
        
        [MethodImpl(Inline)]
        public void Notify(string msg, AppMsgKind? severity = null)
            => Queue.Notify(msg,severity);

        public void Flush(Exception e, IAppMsgLog target)
        {
            target.Write(Flush(e));
        }

        public void Flush(FilePath dst) => Queue.Flush(dst);

        public IReadOnlyList<AppMsg> Flush(Exception e)        
        {
            var messages = Queue.Flush(e);            
            Terminal.Get().WriteMessages(messages);
            return messages;
        }
    }    
}