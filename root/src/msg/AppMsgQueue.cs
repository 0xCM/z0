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

        public IReadOnlyList<AppMsg> Flush()
        {
            lock(lockobj)
            {
                var messages = Messages.ToArray();
                Messages.Clear();
                return messages;
            }
        }

        public void Notify(AppMsg msg)
        {
            lock(lockobj)
                Messages.Add(msg);
        }

        public IReadOnlyList<AppMsg> Flush(Exception e)
        {
            lock(lockobj)
            {
                Notify(AppMsg.NoCaller($"{e}", AppMsgKind.Error));
                return Flush();
            }
        }
        
        public void Notify(string msg, AppMsgKind? severity = null)
            => Notify(AppMsg.NoCaller($"{msg}", severity ?? AppMsgKind.Babble));
    }
}