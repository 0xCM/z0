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
        public IWfContext Wf {get;}

        public IAppContext Root {get;}

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
        public WfCaptureState(IWfContext wf, IAsmContext asm, WfConfig config, CorrelationToken ct)
        {
            Wf = wf;
            Root = wf.ContextRoot;
            Asm = asm;
            Ct = ct;
            Config = config;
            Log = AB.log(Config);
            var srcpath = FilePath.Define(wf.GetType().Assembly.Location).FolderPath;
            var dstpath = wf.AppPaths.AppCaptureRoot;
            var src = new ArchiveConfig(srcpath);
            var dst = new ArchiveConfig(dstpath);
            Settings = CaptureConfig.From(wf.ContextRoot.Settings);
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

        public void Created(string actor, CorrelationToken ct)
            => Wf.Created(actor, Ct);

        public void Running(string actor, CorrelationToken ct)
            => Wf.Running(actor, ct);

        public void Running<T>(string actor, T message, CorrelationToken ct)
            => Wf.RunningT(actor, message, ct);

        public void Ran<T>(string actor, T content, CorrelationToken ct)
            => Wf.RanT(actor, content, ct);

        public void Ran(string actor, CorrelationToken ct)
            => Wf.Ran(actor, Ct);

        public void Finished(string actor, CorrelationToken ct)
            => Wf.Finished(actor, Ct);

        public void Initializing(WfStepId step, CorrelationToken ct)
            => Wf.Initializing(step, Ct);

        public void Initialized(WfStepId step,  CorrelationToken ct)
            => Wf.Initialized(step, Ct);

        public void Error(string actor, Exception e, CorrelationToken ct)
            => Wf.Error(actor, e, Ct);

        public void Error(string actor, string message, CorrelationToken ct)
            => Wf.Error(actor, message, ct);

        public WfEventId Raise<E>(in E @event)
            where E : IWfEvent
                => Wf.Raise(@event);
    }
}