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

        public event Action<AppMsg> Next;

        /// <summary>
        /// Creates a message context that manages its own queue
        /// </summary>
        /// <param name="queue">The target queue</param>
        public static IAppMsgContext Create(IAppMsgQueue dst)
            => new AppMsgContext(dst);          

        public static IAppMsgContext Create()
            => new AppMsgContext();

        AppMsgContext(IAppMsgQueue dst)
        {
            Queue = dst;
            Queue.Next += Relay;
            Next += BlackHole;
        }

        AppMsgContext()
        {
            Queue = AppMsgQueue.Create();
            Queue.Next += Relay;
            Next += BlackHole;
        }

        public IReadOnlyList<AppMsg> Dequeue()
            => Queue.Dequeue();

        void BlackHole(AppMsg msg) {}


        void Relay(AppMsg msg)
            => Next(msg);

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
            => target.Write(Flush(e));

        public void Emit(FilePath dst) 
            => Queue.Emit(dst);

        public IReadOnlyList<AppMsg> Flush(Exception e)        
        {
            var messages = Queue.Flush(e);            
            Terminal.Get().WriteMessages(messages);
            return messages;
        }
    }    
}