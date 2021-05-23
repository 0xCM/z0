//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static EventFactory;
    using static Root;

    public class EventSignal
    {
        [MethodImpl(Inline)]
        public static EventSignal create(IEventSink sink, WfHost host, CorrelationToken ct = default)
            => new EventSignal(sink, host, ct);

        [MethodImpl(Inline)]
        public static EventSignal create(IEventSink sink, Type host, CorrelationToken ct = default)
            => new EventSignal(sink, host, ct);


        readonly IEventSink Sink;

        readonly CorrelationToken Ct;

        readonly WfHost Source;

        [MethodImpl(Inline)]
        EventSignal(IEventSink sink, WfHost src, CorrelationToken ct)
        {
            Ct = ct;
            Source = src;
            Sink = sink;
        }

        public EventId Raise<E>(in E e)
            where E : IWfEvent
        {
            Sink.Deposit(e);
            return e.EventId;
        }

        public void TableEmitting(Type type, FS.FilePath dst)
            => Raise(emittingTable(Source, type, dst, Ct));

        public void EmittingTable<T>(FS.FilePath dst)
            => Raise(emittingTable<T>(Source, dst, Ct));

        public void Ran<T>(T data)
            => Raise(ran(Source, data, Ct));

        public void Ran(CmdResult cmd)
            => Raise(new RanCmdEvent(cmd, Ct));

        public void Running()
            => Raise(running(Source, Ct));

        public void Running(WfHost host)
            => Raise(running(host, Ct));

        public void Running<T>(WfHost host, T data)
            => Raise(running(host, data, Ct));

        public void Running<T>(T data)
            => Raise(running(Source, data, Ct));

        public void Running<T>(string operation, T data)
            => Raise(running(Source, operation, data, Ct));

        public void Processed<T>(T data)
            => Raise(processed(Source, data, Ct));

        public void Processed<T>(ApiHostUri uri, T data)
            => Raise(processed(Source, Seq.delimit(Chars.Pipe, 0, uri, data), Ct));

        public void Creating<T>(T data)
            => Raise(creating(Source, data, Ct));

        public void Created<T>(T data)
            => Raise(created(Source, data, Ct));

        public void EmittedTable<T>(Count count, FS.FilePath dst)
            where T : struct
                => Raise(emittedTable<T>(Source, count, dst, Ct));

        public void EmittedTable<T>(FS.FilePath dst)
            where T : struct
                => Raise(emittedTable<T>(Source, dst, Ct));

        public void EmittedTable(Type type, Count count, FS.FilePath dst)
            => Raise(emittedTable(Source, TableId.identify(type), count, dst, Ct));

        public void EmittedTable(Type type, FS.FilePath dst)
            => Raise(emittedTable(Source, TableId.identify(type), dst, Ct));

        public void EmittingFile(FS.FilePath dst)
            => Raise(emittingFile(Source, dst, Ct));

        public void EmittedFile(FS.FilePath dst)
            => Raise(emittedFile(Source, dst, Ct));

        public void EmittedFile(Count count, FS.FilePath dst)
            => Raise(emittedFile(Source, dst, count, Ct));

        public void EmittingFile<T>(T payload, FS.FilePath dst)
            => Raise(emittingFile<T>(Source, payload, dst, Ct));

        public void EmittedFile<T>(T payload, Count count, FS.FilePath dst)
            => Raise(emittedFile(Source, payload, count, dst, Ct));

        public void EmittedFile<T>(T payload, FS.FilePath dst)
            => Raise(emittedFile(Source, payload, dst, Ct));

        public void Status<T>(WfStepId step, T data)
            => Raise(status(step, data));

        public void Status<T>(T data)
            => Status(Source, data);

        public void Babble<T>(WfStepId step, T data)
            => Raise(babble(step, data, Ct));

        public void Babble<T>(T data)
            => Babble(Source, data);

        public void Error<T>(T body)
            => Raise(error(Source.Identifier, body));

        public void Error<T>(WfStepId step, T body, EventOrigin source)
            => Raise(error(step, body, source));

        public void Error(WfStepId step, Exception e, EventOrigin source)
            => Raise(error(step, e, source));

        public void Error(Exception e, EventOrigin source)
            => Raise(error(Source, e, source));

        public void Error<T>(T body, EventOrigin source)
            => Error(Source, body, source);

        public void Warn<T>(WfStepId step, T content)
            => Raise(warn(step, content, Ct));

        public void Warn<T>(T content)
            => Warn(Source,content);
    }
}