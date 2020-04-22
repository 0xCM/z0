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
    
    using static Seed;

    public sealed class AppMsgExchange : IAppMsgExchange
    {
        readonly IAppMsgQueue Queue;

        /// <summary>
        /// Creates an exchange over an existing queue
        /// </summary>
        public static IAppMsgExchange Create(IAppMsgQueue queue)
            => new AppMsgExchange(queue);

        /// <summary>
        /// Creates an exchange and underlying queue
        /// </summary>
        public static IAppMsgExchange Create()
            => new AppMsgExchange(AppMsgQueue.Create());

        AppMsgExchange(IAppMsgQueue dst)
        {
            void Relay(IAppMsg msg)
                => Next(msg);

            Queue = dst;
            Queue.Next += Relay;
            Next = x => {};
        }

        public event Action<IAppMsg> Next;        

        /// <summary>
        /// Enqueues application messages
        /// </summary>
        /// <param name="msg">The messages to enqueue</param>
        [MethodImpl(Inline)]
        public void Deposit(IAppMsg msg)
            => Queue.Deposit(msg);
        
        [MethodImpl(Inline)]
        public void Notify(string msg, AppMsgKind? severity = null)
            => Queue.Notify(msg,severity);

        public IReadOnlyList<IAppMsg> Dequeue()
            => Queue.Dequeue();

        public void Emit(FilePath dst) 
            => Queue.Emit(dst);

        public IReadOnlyList<IAppMsg> Flush(Exception e)        
        {
            var messages = Queue.Flush(e);            
            Terminal.Get().WriteMessages(messages);
            return messages;
        }

        public void Flush(Exception e, IAppMsgSink target)
            => target.Deposit(Flush(e));
    }
}