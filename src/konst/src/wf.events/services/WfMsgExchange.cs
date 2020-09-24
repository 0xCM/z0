//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;

    public interface IWfMsgExchange : IAppMsgQueue
    {
        void IAppMsgSink.Deposit(IEnumerable<IAppMsg> msg)
        {}

        void IAppMsgSink.Notify(string msg, MessageKind? kind)
        {}

        void IAppMsgSink.NotifyConsole(IAppMsg msg)
        {
        }

        void ISink<IAppMsg>.Deposit(IAppMsg src)
        {}
        IReadOnlyList<IAppMsg> IAppMsgQueue.Dequeue()
            => sys.empty<IAppMsg>();

        void IAppMsgQueue.Emit(FilePath dst)
        {}

        IReadOnlyList<IAppMsg> IAppMsgQueue.Flush(Exception e)
            => sys.empty<IAppMsg>();

        void IAppMsgQueueFlush(Exception e, IAppMsgSink target)
        {}
    }

    public sealed class WfMsgExchange : IWfMsgExchange
    {
        readonly IWfShell Wf;

        public event Action<IAppMsg> Next;

        /// <summary>
        /// Creates an exchange and underlying queue
        /// </summary>
        public static IWfMsgExchange Create(IWfShell wf)
            => new WfMsgExchange(wf);

        public WfMsgExchange(IWfShell wf)
        {
            Wf = wf;
            Next = x => {};
        }

        // void Relay(IAppMsg src)
        // {

        // }


        // [MethodImpl(Inline)]
        // public void Notify(string msg, MessageKind? severity = null)
        // {

        // }

        // public IReadOnlyList<IAppMsg> Dequeue()
        //     => z.list<IAppMsg>();

        // public void Emit(FilePath dst)
        // {

        // }

        // public IReadOnlyList<IAppMsg> Flush(Exception e)
        //     => z.list<IAppMsg>();

        // public void Flush(Exception e, IAppMsgSink target)
        // {

        // }

        // public void Deposit(IAppMsg msg)
        // {}
    }
}