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

    public sealed class AppMsgExchange : IAppMsgExchange, IAppMsgContext
    {
        readonly IAppMsgQueue Queue;

        public event Action<IAppMsg> Next;

        public static IAppMsgExchange From(IAppMsgQueue dst)
            => new AppMsgExchange(dst);          

        public static IAppMsgExchange New()
            => new AppMsgExchange();

        AppMsgExchange(IAppMsgQueue dst)
        {
            Queue = dst;
            Queue.Next += Relay;
            Next += BlackHole;
        }

        AppMsgExchange()
        {
            Queue = AppMessages.queue();
            Queue.Next += Relay;
            Next += BlackHole;
        }

        void BlackHole(IAppMsg msg) {}

        void Relay(IAppMsg msg)
            => Next(msg);

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

        public void Flush(Exception e, IAppMsgSink target)
            => target.Deposit(Flush(e));

        public void Emit(FilePath dst) 
            => Queue.Emit(dst);

        public IReadOnlyList<IAppMsg> Flush(Exception e)        
        {
            var messages = Queue.Flush(e);            
            Terminal.Get().WriteMessages(messages);
            return messages;
        }
    }
}