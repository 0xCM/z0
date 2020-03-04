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

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Root;

    /// <summary>
    /// A container of messages which isnt't realy a queue but is more-or-less thread-safe
    /// </summary>
    public class AppMsgQueue
    {
        object lockobj = new object();

        List<AppMsg> Messages {get;} 

        public static AppMsgQueue Create(params AppMsg[] src)
            => new AppMsgQueue(src);

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

        public void Post(AppMsg msg)
        {
            lock(lockobj)
                Messages.Add(msg);
        }

        public IReadOnlyList<AppMsg> Flush(Exception e)
        {
            lock(lockobj)
            {
                Post(AppMsg.NoCaller($"{e}", AppMsgKind.Error));
                return Dequeue();
            }
        }

        public void Post(string msg, AppMsgKind? severity = null)
            => Post(AppMsg.NoCaller($"{msg}", severity ?? AppMsgKind.Babble));
    }
}