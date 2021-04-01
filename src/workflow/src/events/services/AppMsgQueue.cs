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

    using static Part;

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
            lock(lockobj)
                Messages.Add(msg);

            Relay(msg);
        }

        public IReadOnlyList<IAppMsg> Flush(Exception e)
        {
            lock(lockobj)
            {
                Deposit(AppMsg.define($"{e}", LogLevel.Error));
                return Dequeue();
            }
        }

        public void Notify(string msg, LogLevel? severity = null)
            => Deposit(AppMsg.define($"{msg}", severity ?? LogLevel.Babble));

        public void Emit(FS.FilePath dst)
        {
            try
            {
                using var writer = dst.Writer();
                root.iter(Dequeue(), msg => writer.WriteLine(msg.Format()));
            }
            catch(Exception)
            {
                term.red($"Error writing to {dst}");
                throw;
            }
        }
    }
}