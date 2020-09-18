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

    public sealed class WfMsgExchange : IAppMsgQueue
    {
        readonly IWfShell Wf;

        /// <summary>
        /// Creates an exchange and underlying queue
        /// </summary>
        public static IAppMsgQueue Create(IWfShell wf)
            => new WfMsgExchange(wf);

        public WfMsgExchange(IWfShell wf)
        {
            Wf = wf;
            Next = x => {};
        }

        void Relay(IAppMsg src)
        {

        }

        public event Action<IAppMsg> Next;

        [MethodImpl(Inline)]
        public void Notify(string msg, MessageKind? severity = null)
        {

        }

        public IReadOnlyList<IAppMsg> Dequeue()
            => z.list<IAppMsg>();

        public void Emit(FilePath dst)
        {

        }

        public IReadOnlyList<IAppMsg> Flush(Exception e)
            => z.list<IAppMsg>();

        public void Flush(Exception e, IAppMsgSink target)
        {

        }

        public void Deposit(IAppMsg msg)
        {}
    }

}