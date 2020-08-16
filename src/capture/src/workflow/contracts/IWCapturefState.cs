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
        IWfContext Wf {get;}

        IAppContext ContextRoot {get;}        

        IAsmContext Asm {get;}        

        WfConfig Config {get;}        

        IWfCaptureService CWf {get;}
        
        AsmFormatSpec FormatConfig {get;}

        AsmFormatter Formatter {get;}        

        TCaptureServices Services{get;}        

        IAsmFunctionDecoder FunctionDecoder {get;}

        IWfCaptureBroker CaptureBroker {get;}

        IWfCaptureBroker IWfCaptureService.Broker 
            => CaptureBroker;

        ICaptureContext IWfCaptureService.Context
            => CWf.Context;            
    }    
}