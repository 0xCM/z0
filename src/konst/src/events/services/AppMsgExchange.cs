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
    
    using static Konst;

    public sealed class AppMsgExchange : IAppMsgQueue
    {
        readonly IAppMsgQueue Queue;

        /// <summary>
        /// Creates an exchange over an existing queue
        /// </summary>
        public static AppMsgExchange Create(IAppMsgQueue queue)
            => new AppMsgExchange(queue);

        /// <summary>
        /// Creates an exchange and underlying queue
        /// </summary>
        public static AppMsgExchange Create()
            => new AppMsgExchange(AppMsgQueue.Create());

        AppMsgExchange(IAppMsgQueue dst)
        {
            Queue = dst;
            Queue.Next += Relay;
            Next = x => {};
        }

        void Relay(IAppMsg src)
        {
            term.print(src);
        }
        
        public event Action<IAppMsg> Next;        
        
        [MethodImpl(Inline)]
        public void Notify(string msg, AppMsgKind? severity = null)
        {
           Queue.Notify(msg, severity);
        }

        public IReadOnlyList<IAppMsg> Dequeue()
            => Queue.Dequeue();

        public void Emit(FilePath dst) 
            => Queue.Emit(dst);

        public IReadOnlyList<IAppMsg> Flush(Exception e)        
        {
            var messages = Queue.Flush(e);            
            z.iter(messages, msg => term.print(msg));
            return messages;
        }

        public void Flush(Exception e, IAppMsgSink target)
            => target.Deposit(Flush(e));

        public void Deposit(IAppMsg msg)
            => Queue.Deposit(msg);
    }
}