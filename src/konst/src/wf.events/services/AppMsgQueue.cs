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
            z.insist(msg);
            lock(lockobj)
                Messages.Add(msg);

            Relay(msg);
        }

        public IReadOnlyList<IAppMsg> Flush(Exception e)
        {
            lock(lockobj)
            {
                Deposit(AppMsg.define($"{e}", MessageKind.Error));
                return Dequeue();
            }
        }

        public void Notify(string msg, MessageKind? severity = null)
            => Deposit(AppMsg.define($"{msg}", severity ?? MessageKind.Babble));

        public void Emit(FilePath dst)
        {
            try
            {
                using var writer = dst.Writer();
                z.iter(Dequeue(), msg => writer.WriteLine(msg.Format()));
            }
            catch(Exception)
            {
                term.red($"Error writing to {dst}");
                throw;
            }
        }
    }
}