//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfCaptureState : IWfCaptureState
    {
        public IAppContext App {get;}

        public IWfShell Wf {get;}

        public IAsmContext Asm {get;}

        public IWfCaptureContext CWf {get;}

        public CaptureConfig Settings {get;}

        public WfConfig Config {get;}

        public AsmFormatSpec FormatConfig {get;}

        public AsmFormatter Formatter {get;}

        public TCaptureServices Services{get;}

        public IAsmDecoder RoutineDecoder {get;}

        public CorrelationToken Ct {get;}

        public IWfCaptureBroker CaptureBroker {get;}

        readonly IWfEventLog Log;

        public PartId[] Parts {get;}

        [MethodImpl(Inline)]
        public WfCaptureState(IWfShell wf, IAsmContext asm, WfConfig config, CorrelationToken ct)
        {
            Wf = wf;
            Asm = asm;
            App = asm.ContextRoot;
            Ct = ct;
            Config = config;
            Log = AB.log(Config, ct);
            var srcpath = FilePath.Define(wf.GetType().Assembly.Location).FolderPath;
            var dstpath = wf.AppPaths.AppCaptureRoot;
            var src = new ArchiveConfig(srcpath);
            var dst = new ArchiveConfig(dstpath);
            Settings = CaptureConfig.From(wf.Settings);
            Services = CaptureServices.create(Asm);
            FormatConfig = AsmFormatSpec.WithSectionDelimiter;
            Formatter = Services.Formatter(FormatConfig);
            RoutineDecoder = Services.RoutineDecoder(FormatConfig);
            CWf = new WfCaptureContext(Asm, Wf, RoutineDecoder, Formatter, Services.AsmWriterFactory, Archives.capture(Config.TargetArchive), Ct);
            CaptureBroker = AsmWfBuilder.capture(Log, ct);
            Parts = Wf.Config.Parts.Length == 0 ? Asm.ContextRoot.Api.PartIdentities : Wf.Config.Parts;
        }

        public void Dispose()
        {
            Log.Dispose();
        }

        public ICaptureContext CaptureContext
            => CWf.Context;

        public IAppEventSink AppEventSink
            => CWf.Broker.Sink;

        public IWfEventSink WfEventSink
            => Wf.Broker.Sink;

        public void Created(WfStepId actor)
            => Wf.Created(actor, Ct);

        public void Created(string actor, CorrelationToken ct)
            => Wf.Created(actor, Ct);

        public void Running(string actor, CorrelationToken ct)
            => Wf.Running(actor, ct);

        public void Running<T>(WfStepId step, T content)
            => Wf.Running(step, content);

        public void Ran(WfStepId step)
            => Wf.Ran(step, Ct);

        public void Ran<T>(WfStepId step, T content)
            => Wf.Ran(step, content);

        public void Finished(WfStepId actor)
            => Wf.Finished(actor, Ct);

        public void Finished(string actor, CorrelationToken ct)
            => Wf.Finished(actor, Ct);

        public void Error(string actor, Exception e, CorrelationToken ct)
            => Wf.Error(actor, e, Ct);

        public void Error(string actor, string message, CorrelationToken ct)
            => Wf.Error(actor, message, ct);

        public WfEventId Raise<E>(in E @event)
            where E : IWfEvent
                => Wf.Raise(@event);
    }
}