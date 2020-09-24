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
        public IWfShell Wf {get;}

        public IAppContext App {get;}

        public IAsmContext Asm {get;}

        public IWfCaptureContext CWf {get;}

        public CaptureConfig Settings {get;}

        public IWfInit Config {get;}

        public AsmFormatConfig FormatConfig {get;}

        public AsmFormatter Formatter {get;}

        public TCaptureServices Services{get;}

        public IAsmDecoder RoutineDecoder {get;}

        public CorrelationToken Ct {get;}

        public IWfCaptureBroker CaptureBroker {get;}

        public PartId[] Parts {get;}

        [MethodImpl(Inline)]
        public WfCaptureState(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            Ct = Wf.Ct;
            Asm = asm;
            App = asm.ContextRoot;
            Config = wf.Init;
            var srcpath = FilePath.Define(wf.GetType().Assembly.Location).FolderPath;
            var dstpath = wf.Paths.AppCaptureRoot;
            var src = new ArchiveConfig(srcpath);
            var dst = new ArchiveConfig(dstpath);
            Settings = CaptureConfig.From(wf.Settings);
            Services = CaptureServices.create(Asm);
            FormatConfig = AsmFormatConfig.WithSectionDelimiter;
            Formatter = Services.Formatter(FormatConfig);
            RoutineDecoder = Services.RoutineDecoder(FormatConfig);
            CWf = new WfCaptureContext(Wf, RoutineDecoder, Formatter, ApiArchives.capture(Config.TargetArchive));
            CaptureBroker = AsmWorkflows.capture(wf);
            Parts = Wf.Init.PartIdentities.Length == 0 ? Wf.Api.Identifiers : Wf.Init.PartIdentities;
        }

        public void Dispose()
        {

        }

        public void Error(WfStepId step, Exception e)
            => Wf.Error(step, e);
    }
}