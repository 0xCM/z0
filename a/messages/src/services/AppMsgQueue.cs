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
    
    using static Core;

    /// <summary>
    /// A container of messages which isnt't realy a queue but is more-or-less thread-safe
    /// </summary>
    public class AppMsgQueue : IAppMsgQueue
    {
        object lockobj = new object();

        public event Action<AppMsg> Next;

        List<AppMsg> Messages {get;} 

        [MethodImpl(Inline)]
        public static AppMsgQueue Create(params AppMsg[] src)
            => new AppMsgQueue(src);

        [MethodImpl(Inline)]
        AppMsgQueue(params AppMsg[] src)
        {
            this.Messages = src.ToList();
            this.Next += BlackHole;
        }

        void BlackHole(AppMsg msg) { }

        void Relay(AppMsg msg)
            => Next(msg);

        public IReadOnlyList<AppMsg> Dequeue()
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
            
            Relay(msg);
        }

        public IReadOnlyList<AppMsg> Flush(Exception e)
        {
            lock(lockobj)
            {
                Notify(AppMsg.NoCaller($"{e}", AppMsgKind.Error));
                return Dequeue();
            }
        }

        public void Emit(FilePath dst)
        {
            using var writer = dst.Writer();
            Streams.iter(Dequeue(), msg => writer.WriteLine(msg.Format()));
        }

        public void Notify(string msg, AppMsgKind? severity = null)
            => Notify(AppMsg.NoCaller($"{msg}", severity ?? AppMsgKind.Babble));
    }
}