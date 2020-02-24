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
    /// A container of messages which isnt't realy a queue and is certainly not thread-safe
    /// </summary>
    public class AppMsgQueue
    {
        List<AppMsg> Messages {get;} 

        public static AppMsgQueue Create(params AppMsg[] src)
            => new AppMsgQueue(src);

        AppMsgQueue(params AppMsg[] src)
        {
            this.Messages = src.ToList();
        }

        public IReadOnlyList<AppMsg> Dequeue()
        {
            var messages = Messages.ToArray();
            Messages.Clear();
            return messages;
        }

        public void Post(AppMsg msg)
        {
            Messages.Add(msg);
        }

        public void Post(string msg, SeverityLevel? severity = null)
            => Post(AppMsg.Define($"{msg}", severity ?? SeverityLevel.Babble));
    }
}