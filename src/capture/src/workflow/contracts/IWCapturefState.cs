//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    public interface IWfCaptureState : IWfCaptureContext
    {
        IAppContext Root {get;}

        IWfContext Wf {get;}

        WfConfig Config {get;}

        IAsmContext Asm {get;}

        IWfCaptureContext CWf {get;}

        AsmFormatSpec FormatConfig {get;}

        AsmFormatter Formatter {get;}

        TCaptureServices Services{get;}

        IAsmDecoder RoutineDecoder {get;}

        IWfCaptureBroker CaptureBroker {get;}

        IWfCaptureBroker IWfCaptureContext.Broker
            => CaptureBroker;

        ICaptureContext IWfCaptureContext.Context
            => CWf.Context;
    }
}