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
        IWfShell Wf {get;}

        IAppContext App {get;}

        IAsmContext Asm {get;}

        IWfCaptureContext CWf {get;}

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