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

        public void Ran()
            => Raise(new RanEvent(Host, Ct));

        public void Ran<T>(T data)
            => Raise(ran(Host, data, Ct));

        public void Ran(WfStepId step)
            => Raise(ran(step, Ct));

        public void Ran(CmdResult cmd)
            => Raise(new RanCmdEvent(cmd, Ct));

        public void Running(CmdSpec cmd)
            => Raise(new RunningCmdEvent(cmd.CmdId, Ct));

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

        public void Processing<T>(FS.FilePath src, T data)
            => Raise(processing(Host, src, data, Ct));

        public void Processed<T>(FS.FilePath src, T data)
            => Raise(processed(Host, src, data, Ct));

        public void Processed<T,M>(FS.FilePath src, T data, M metric)
            => Raise(processed(Host, src, data, metric, Ct));

        public void Processed<T>(T content)
            => Raise(processed(Host, content, Ct));

        public void Processed<T>(ApiHostUri uri, T content)
            => Raise(processed(Host, Seq.delimit(uri,content), Ct));

        public void EmittedTable<T>(WfStepId step, Count count, FS.FilePath dst)
            where T : struct
                => Raise(emittedTable<T>(step, count, dst, Ct));

        public void EmittedTable<T>(Count count, FS.FilePath dst)
            where T : struct
                => Raise(emittedTable<T>(Host, count, dst, Ct));

        public void EmittedTable(Type type, Count count, FS.FilePath dst)
            => Raise(emittedTable(Host, type, count, dst, Ct));

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
            => Raise(status(step, data, Ct));

        public void Status<T>(T data)
            => Status(Host, data);

        public void Error<T>(WfStepId step, T body)
            => Raise(error(step, body, Ct));

        public void Error(WfStepId step, Exception e)
            => Raise(error(step, e, Ct));

        public void Error(Exception e)
            => Raise(error(Host, e, Ct));

        public void Error<T>(T body)
            => Error(Host, body);

        public void Warn<T>(WfStepId step, T content)
            => Raise(warn(step, content, Ct));

        public void Warn<T>(T content)
            => Warn(Host,content);
    }
}