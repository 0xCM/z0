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
    using System.IO;
    
    using static Root;

    public readonly struct MsgContextQueue : IAppMsgQueue
    {
        public IContext Context {get;}

        readonly AppMsgQueue Messages;

        [MethodImpl(Inline)]
        public static IAppMsgQueue Create(IContext context)  
        {      
            return new MsgContextQueue(context, AppMsgQueue.Create());
        }
        
        [MethodImpl(Inline)]
        MsgContextQueue(IContext context, AppMsgQueue queue)
        {
            this.Context = context;
            this.Messages = queue;
        }

        /// <summary>
        /// Enqueues application messages
        /// </summary>
        /// <param name="msg">The messages to enqueue</param>
        [MethodImpl(Inline)]
        public void Enqueue(AppMsg msg)
            => Messages.Post(msg);

        [MethodImpl(Inline)]
        public void Enqueue(string msg, AppMsgKind? severity = null)
            => Messages.Post(msg,severity);
       
        public IReadOnlyList<AppMsg> Dequeue()
            => EmitMessages(Messages.Dequeue());

        public IReadOnlyList<AppMsg> Flush(Exception e)
            => EmitMessages(Messages.Flush(e));

        IReadOnlyList<AppMsg> EmitMessages(IReadOnlyList<AppMsg> src)
        {                    
            var errors = src.Where(m => m.Kind == AppMsgKind.Error).FormatLines().ToArray();
            if(errors.Length != 0)
                Context.Paths.StandardErrorPath.AppendAsync(errors);
                                
            var standard = src.Where(m => m.Kind != AppMsgKind.Error).FormatLines().ToArray();
            if(standard.Length != 0)
                Context.Paths.StandardOutPath.AppendAsync(standard);
            return src;
        }
    }
}