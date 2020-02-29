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

    public readonly struct MsgContextQueue : IAppMsgSink
    {
        readonly AppMsgQueue Messages;

        [MethodImpl(Inline)]
        public static MsgContextQueue Create()        
            => new MsgContextQueue(AppMsgQueue.Create());
        
        [MethodImpl(Inline)]
        MsgContextQueue(AppMsgQueue queue)
            => this.Messages = queue;

        /// <summary>
        /// Enqueues application messages
        /// </summary>
        /// <param name="msg">The messages to enqueue</param>
        [MethodImpl(Inline)]
        public void PostMessage(AppMsg msg)
            => Messages.Post(msg);

        [MethodImpl(Inline)]
        public void PostMessage(string msg, AppMsgKind? severity = null)
            => Messages.Post(msg,severity);
       
        [MethodImpl(Inline)]
        internal IReadOnlyList<AppMsg> Dequeue()
            => Messages.Dequeue(); 

        [MethodImpl(Inline)]
        internal IReadOnlyList<AppMsg> Flush(Exception e)
            => Messages.Flush(e);
    }
}