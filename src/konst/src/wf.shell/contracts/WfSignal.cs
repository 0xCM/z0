//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static WfEvents;
    using static Part;

    readonly struct WfSignal
    {
        [MethodImpl(Inline)]
        public static WfSignal create(IWfShell wf)
            => new WfSignal(wf);

        readonly IWfShell Wf;

        [MethodImpl(Inline)]
        WfSignal(IWfShell wf)
            => Wf = wf;

        CorrelationToken Ct
            => Wf.Ct;

        WfHost Host
            => Wf.Host;

        public WfEventId Raise<E>(in E e)
            where E : IWfEvent
        {
            Wf.WfSink.Deposit(e);
            return e.EventId;
        }

        public void TableEmitting(Type type, FS.FilePath dst)
            => Raise(tableEmitting(Host, type, dst, Ct));

        public void TableEmitting<T>(FS.FilePath dst)
            => Raise(tableEmitting<T>(Host, dst, Ct));

        public void Ran()
            => Raise(new RanEvent(Host, Ct));

        public void Ran<T>(T data)
            => Raise(ran(Host, data, Ct));

        public void Ran(WfStepId step)
            => Raise(ran(step, Ct));

        public void Ran(CmdResult cmd)
            => Raise(new RanCmdEvent(cmd, Ct));

        public void Running()
            => Raise(running(Host, Ct));

        public void Running(WfHost host)
            => Raise(running(host, Ct));

        public void Running<T>(WfHost host, T data)
            => Raise(running(host, data, Ct));

        public void Running<T>(T src)
            => Raise(running(Host, src, Ct));
    }
}