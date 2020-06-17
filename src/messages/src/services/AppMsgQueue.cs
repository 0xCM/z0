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
    using static Memories;

    /// <summary>
    /// A container of messages which isnt't realy a queue but is more-or-less thread-safe
    /// </summary>
    class AppMsgQueue : IAppMsgQueue, IAppMsgContext
    {
        object lockobj = new object();

        public event Action<IAppMsg> Next;

        List<IAppMsg> Messages {get;} 

        [MethodImpl(Inline)]
        public static AppMsgQueue Create()
            => new AppMsgQueue();

        [MethodImpl(Inline)]
        AppMsgQueue()
        {
            Messages = new List<IAppMsg>();
            Next = x => {};
        }

        [MethodImpl(Inline)]
        void Relay(IAppMsg msg) 
            => Next(msg);

        public IReadOnlyList<IAppMsg> Dequeue()
        {
            lock(lockobj)
            {
                var messages = Messages.ToArray();
                Messages.Clear();
                return messages;
            }
        }

        public void Deposit(IAppMsg msg)
        {
            insist(msg != null, $"Depositing null messages to the queue is bad");
            lock(lockobj)
                Messages.Add(msg);
            
            Relay(msg);
        }

        public IReadOnlyList<IAppMsg> Flush(Exception e)
        {
            lock(lockobj)
            {
                Deposit(AppMsg.NoCaller($"{e}", AppMsgKind.Error));
                return Dequeue();
            }
        }

        public void Notify(string msg, AppMsgKind? severity = null)
            => Deposit(AppMsg.NoCaller($"{msg}", severity ?? AppMsgKind.Babble));

        public void Emit(FilePath dst)
        {
            try
            {
                using var writer = dst.Writer();
                Control.iter(Dequeue(), msg => writer.WriteLine(msg.Format()));
            }
            catch(Exception)
            {
                term.red($"Error writing to {dst}");                
                throw;
            }
        }
    }
}