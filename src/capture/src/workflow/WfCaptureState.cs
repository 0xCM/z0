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

        public IWfConfig Config {get;}

        public AsmFormatSpec FormatConfig {get;}

        public AsmFormatter Formatter {get;}

        public TCaptureServices Services{get;}

        public IAsmDecoder RoutineDecoder {get;}

        public CorrelationToken Ct {get;}

        public IWfCaptureBroker CaptureBroker {get;}

        public PartId[] Parts {get;}

        [MethodImpl(Inline)]
        public WfCaptureState(IWfShell wf, IAsmContext asm, IWfConfig config, CorrelationToken ct)
        {
            Wf = wf;
            Asm = asm;
            App = asm.ContextRoot;
            Ct = ct;
            Config = config;
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
            CaptureBroker = AsmWfBuilder.capture(wf);
            Parts = Wf.Config.PartIdentities.Length == 0 ? Asm.ContextRoot.Api.Identifiers : Wf.Config.PartIdentities;
        }

        public void Dispose()
        {

        }


        public IWfEventSink WfEventSink
            => Wf.Broker.Sink;

        public void Error(WfStepId step, Exception e)
            => Wf.Error(step, e, Ct);

        public void Error(WfStepId step, string message)
            => Wf.Error(step, message);

        public WfEventId Raise<E>(in E @event)
            where E : IWfEvent
                => Wf.Raise(@event);
    }
}