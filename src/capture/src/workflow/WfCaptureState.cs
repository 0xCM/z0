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
        public static WfCaptureState create(IWfShell wf)
            => new WfCaptureState(wf, new AsmContext(Apps.context(wf), wf));

        public IWfShell Wf {get;}

        public IAppContext App {get;}

        public IAsmContext Asm {get;}

        public IWfCaptureContext CWf {get;}

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
            Services = CaptureServices.create(Asm);
            FormatConfig = AsmFormatConfig.WithSectionDelimiter;
            Formatter = Services.Formatter(FormatConfig);
            RoutineDecoder = Services.RoutineDecoder(FormatConfig);
            CWf = new WfCaptureContext(Wf, RoutineDecoder, Formatter, ApiArchives.capture(wf.Db().CaptureRoot()));
            CaptureBroker = AsmWorkflows.broker(wf);
            Parts = Wf.Init.PartIdentities.Length == 0 ? Wf.Api.PartIdentities : Wf.Init.PartIdentities;
        }

        public void Dispose()
        {

        }

        public void Error(WfStepId step, Exception e)
            => Wf.Error(step, e);
    }
}