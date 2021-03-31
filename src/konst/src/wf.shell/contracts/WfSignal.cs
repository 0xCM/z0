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
            => Raise(emittingTable(Host, type, dst, Ct));

        public void EmittingTable<T>(FS.FilePath dst)
            => Raise(emittingTable<T>(Host, dst, Ct));

        public void Ran<T>(T data)
            => Raise(ran(Host, data, Ct));

        public void Ran(CmdResult cmd)
            => Raise(new RanCmdEvent(cmd, Ct));


        public void Running()
            => Raise(running(Host, Ct));

        public void Running(WfHost host)
            => Raise(running(host, Ct));

        public void Running<T>(WfHost host, T data)
            => Raise(running(host, data, Ct));

        public void Running<T>(T data)
            => Raise(running(Host, data, Ct));

        public void Running<T>(string operation, T data)
            => Raise(running(Host, operation, data, Ct));

        public void Processed<T>(T data)
            => Raise(processed(Host, data, Ct));

        public void Processed<T>(ApiHostUri uri, T data)
            => Raise(processed(Host, Seq.delimit(Chars.Pipe, 0, uri, data), Ct));

        public void Creating<T>(T data)
            => Raise(creating(Host, data, Ct));

        public void Created<T>(T data)
            => Raise(created(Host, data, Ct));

        public void EmittedTable<T>(Count count, FS.FilePath dst)
            where T : struct
                => Raise(emittedTable<T>(Host, count, dst, Ct));

        public void EmittedTable<T>(FS.FilePath dst)
            where T : struct
                => Raise(emittedTable<T>(Host, dst, Ct));

        public void EmittedTable(Type type, Count count, FS.FilePath dst)
            => Raise(emittedTable(Host, type, count, dst, Ct));

        public void EmittedTable(Type type, FS.FilePath dst)
            => Raise(emittedTable(Host, type, dst, Ct));

        public void EmittingFile(FS.FilePath dst)
            => Raise(emittingFile(Host, dst, Ct));

        public void EmittedFile(FS.FilePath dst)
            => Raise(emittedFile(Host, dst, Ct));

        public void EmittedFile(Count count, FS.FilePath dst)
            => Raise(emittedFile(Host, dst, count, Ct));

        public void EmittingFile<T>(T payload, FS.FilePath dst)
            => Raise(emittingFile<T>(Host, payload, dst, Ct));

        public void EmittedFile<T>(T payload, Count count, FS.FilePath dst)
            => Raise(emittedFile(Host, payload, count, dst, Ct));

        public void EmittedFile<T>(T payload, FS.FilePath dst)
            => Raise(emittedFile(Host, payload, dst, Ct));

        public void Status<T>(WfStepId step, T data)
            => Raise(status(step, data));

        public void Status<T>(T data)
            => Status(Host, data);

        public void Babble<T>(WfStepId step, T data)
            => Raise(babble(step, data, Ct));

        public void Babble<T>(T data)
            => Babble(Host, data);

        public void Error<T>(WfStepId step, T body, EventOrigin source)
            => Raise(error(step, body, source));

        public void Error(WfStepId step, Exception e, EventOrigin source)
            => Raise(error(step, e, source));

        public void Error(Exception e, EventOrigin source)
            => Raise(error(Host, e, source));

        public void Error<T>(T body, EventOrigin source)
            => Error(Host, body, source);

        public void Warn<T>(WfStepId step, T content)
            => Raise(warn(step, content, Ct));

        public void Warn<T>(T content)
            => Warn(Host,content);
    }
}