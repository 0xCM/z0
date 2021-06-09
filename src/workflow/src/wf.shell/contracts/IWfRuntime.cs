//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Threading.Tasks;

    using static WfEvents;
    using static Root;
    using static core;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface IWfRuntime : IDisposable, ITextual, IEnvContext
    {
        IAppPaths Paths {get;}

        IJsonSettings Settings {get;}

        IApiParts ApiParts {get;}

        CorrelationToken Ct {get;}

        string[] Args {get;}

        string AppName {get;}

        WfController Controller {get;}

        IApiCatalog ApiCatalog {get;}

        IWfContext Context {get;}

        IEventSink EventSink {get;}

        IEventBroker EventBroker {get;}

        ICmdRouter Router {get;}

        IPolySource Polysource {get;}

        WfHost Host {get;}

        LogLevel Verbosity {get;}

        ExecToken NextExecToken();

        IWfRuntime WithSource(IPolySource source);

        //EnvData Env {get;}

        ExecToken Ran(WfExecFlow src);

        ExecToken Ran<T>(WfExecFlow<T> src);

        ExecToken Ran<T,D>(WfExecFlow<T> flow, D data);

        IWfEmissionLog Emissions {get;}

        void RedirectEmissions(IWfEmissionLog dst);

        IRuntimeArchive RuntimeArchive()
            => WfRuntime.RuntimeArchive(this);

        Assembly[] Components
            => Context.ApiParts.Components;

        string ITextual.Format()
            => AppName;

        WfExecFlow<T> Flow<T>(T data)
            => new WfExecFlow<T>(this, data, NextExecToken());

        WfTableFlow<T> TableFlow<T>(FS.FilePath dst)
            where T : struct, IRecord<T>
                => new WfTableFlow<T>(this, dst, NextExecToken());

        WfFileFlow Flow(FS.FilePath dst)
                => new WfFileFlow(this, dst, NextExecToken());

        WfCmdBuilder CmdBuilder()
            => new WfCmdBuilder(this);

        Task<CmdResult> Dispatch(ICmd cmd)
            => Task.Factory.StartNew(() => Router.Dispatch(cmd));

        CmdResult Execute(ICmd cmd)
            => Router.Dispatch(cmd);

        IWfRuntime WithHost(WfHost host)
            => this;

        /// <summary>
        /// Provides a <see cref='IWfDb'/> rooted at a shell-configured location
        /// </summary>
        IWfDb Db()
            => new WfDb(this, Env.Db);

        /// <summary>
        /// Provides a <see cref='IWfDb'/> rooted at a shell-configured location
        /// </summary>
        IWfDb Db(FS.FolderPath root)
            => new WfDb(this, root);

        EventId Raise<E>(in E e)
            where E : IWfEvent
        {
            EventSink.Deposit(e);
            return e.EventId;
        }

        void Status<T>(T data)
            => signal(this).Status(data);

        void Babble<T>(T data)
            => signal(this).Babble(data);

        void Warn<T>(T content)
            => signal(this).Warn(content);

        void Error(WfStepId step, Exception e, [Caller] string caller = null, [File] string file = null, [Line]int? line = null)
            => signal(this).Error(step, e, EventFactory.originate("WorkflowError", caller, file, line));

        void Error(Exception e, [Caller] string caller = null, [File] string file = null, [Line]int? line = null)
            => signal(this).Error(e, EventFactory.originate("WorkflowError", caller, file, line));

        void Error<T>(T data, [Caller] string caller = null, [File] string file = null, [Line]int? line = null)
            => signal(this).Error(data, EventFactory.originate("WorkflowError", caller, file, line));

        /// <summary>
        /// If outcome indicates failure, raises an eror and returns false; otherwise returns true
        /// </summary>
        /// <param name="outcome">The outcome to test</param>
        bool Check(Outcome outcome)
        {
            if(outcome.Fail)
            {
                Error(outcome.Message);
                return false;
            }
            else
            {
                return true;
            }
        }

        bool Check<T>(Outcome<T> outcome, out T payload)
        {
            if(outcome.Fail)
            {
                Error(outcome.Message);
                payload = default;
                return false;
            }
            else
            {
                payload = outcome.Data;
                return true;
            }
        }

        void Disposed()
        {
            if(Verbosity.IsBabble())
                Raise(EventFactory.disposed(Host.StepId, Ct));
        }

        WfExecFlow<T> Creating<T>(T data)
        {
            signal(this).Creating(data);
            return Flow(data);
        }

        ExecToken Created<T>(WfExecFlow<T> flow)
        {
            signal(this).Created(flow.Data);
            return Ran(flow);
        }


        WfTableFlow<T> EmittingTable<T>(FS.FilePath dst)
            where T : struct, IRecord<T>
        {
            signal(this).EmittingTable<T>(dst);
            return Emissions.LogEmission(TableFlow<T>(dst));
        }

        ExecToken EmittedTable<T>(WfTableFlow<T> flow, Count count, FS.FilePath? dst = null)
            where T : struct, IRecord<T>
        {
            var completed = Ran(flow);
            var counted = flow.WithCount(count).WithToken(completed);
            signal(this).EmittedTable<T>(count, counted.Target);
            Emissions.LogEmission(counted);
            return completed;
        }

        WfFileFlow EmittingFile(FS.FilePath dst)
        {
            signal(this).EmittingFile(dst);
            return Emissions.LogEmission(Flow(dst));
        }

        WfFileFlow EmittingFile<T>(FS.FilePath dst, T payload)
        {
            signal(this).EmittingFile(payload, dst);
            return Emissions.LogEmission(Flow(dst));
        }

        ExecToken EmittedFile(WfFileFlow flow, Count count)
        {
            var completed = Ran(flow);
            var counted = flow.WithCount(count).WithToken(completed);
            signal(this).EmittedFile(count, counted.Target);
            Emissions.LogEmission(counted);
            return completed;
        }

        WfExecFlow<string> Running([Caller] string operation = null)
        {
            signal(this).Running(operation);
            return Flow(operation);
        }

        WfExecFlow<T> Running<T>(T data, [Caller] string operation = null)
        {
            signal(this).Running(operation, data);
            return Flow(data);
        }

       void Row<T>(T data)
            => Raise(EventFactory.row(data));


        void Row(ReadOnlySpan<char> src)
            => Row<string>(text.format(src));

        void Row<T>(uint index, T data)
            => Row(string.Format("{0:D4}: {1}", index, data));

        void Row<T>(int index, T data)
            => Row(string.Format("{0:D4}: {1}", index, data));

        void Row<K,T>(uint index, K kind, T data)
            => Row(string.Format("{0:D4}: {1,-12} | {2}", index, kind, data));

        void Row<K,T>(int index, K kind, T data)
            => Row(string.Format("{0:D4}: {1,-12} | {2}", index, kind, data));

        void Rows<T>(T[] src)
            => Rows(@readonly(src), EmptyString);

        void Rows<T>(T[] src, string label)
            => Rows(@readonly(src), label);

        void Rows<T>(ReadOnlySpan<T> src)
            => Rows(src, EmptyString);

        void Rows<T>(ReadOnlySpan<T> src, string label)
        {
            if(src.Length != 0)
            {
                var buffer = text.buffer();
                var count = src.Length;
                if(text.nonempty(label))
                    buffer.AppendLineFormat("Rowset {0}", label);

                for(var i=0; i<count; i++)
                    buffer.AppendLine(skip(src,i));
                Raise(EventFactory.rows(buffer.Emit()));
            }
        }
    }
}