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

    /// <summary>
    /// A container of messages which isnt't realy a queue but is more-or-less thread-safe
    /// </summary>
    public class AppMsgQueue : IAppMsgQueue
    {
        object lockobj = new object();

        List<AppMsg> Messages {get;} 

        [MethodImpl(Inline)]
        public static AppMsgQueue Create(params AppMsg[] src)
            => new AppMsgQueue(src);

        [MethodImpl(Inline)]
        AppMsgQueue(params AppMsg[] src)
        {
            this.Messages = src.ToList();
        }

        public IReadOnlyList<AppMsg> Dequeue()
        {
            lock(lockobj)
            {
                var messages = Messages.ToArray();
                Messages.Clear();
                return messages;
            }
        }

        public void Enqueue(AppMsg msg)
        {
            lock(lockobj)
                Messages.Add(msg);
        }

        public IReadOnlyList<AppMsg> Flush(Exception e)
        {
            lock(lockobj)
            {
                Enqueue(AppMsg.NoCaller($"{e}", AppMsgKind.Error));
                return Dequeue();
            }
        }
        
        public void Enqueue(string msg, AppMsgKind? severity = null)
            => Enqueue(AppMsg.NoCaller($"{msg}", severity ?? AppMsgKind.Babble));
    }
}