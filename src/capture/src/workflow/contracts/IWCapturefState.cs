//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    public interface IWfCaptureState : IWfCaptureService
    {
        IAppContext Root {get;}        

        IWfContext Wf {get;}

        WfConfig Config {get;}        

        IAsmContext Asm {get;}        

        IWfCaptureService CWf {get;}
        
        AsmFormatSpec FormatConfig {get;}

        AsmFormatter Formatter {get;}        

        TCaptureServices Services{get;}        

        IAsmDecoder RoutineDecoder {get;}

        IWfCaptureBroker CaptureBroker {get;}

        IWfCaptureBroker IWfCaptureService.Broker 
            => CaptureBroker;

        ICaptureContext IWfCaptureService.Context
            => CWf.Context;            
    }    
}