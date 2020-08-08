//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    public interface IWfState : ICaptureWorkflow
    {
        IWfContext Wf {get;}

        IAppContext ContextRoot {get;}        

        IAsmContext Asm {get;}        

        WfConfig Config {get;}        

        ICaptureWorkflow CWf {get;}
        
        AsmFormatSpec FormatConfig {get;}

        AsmFormatter Formatter {get;}        

        TCaptureServices Services{get;}        

        IAsmFunctionDecoder FunctionDecoder {get;}

        ICaptureBroker CaptureBroker {get;}

        ICaptureBroker ICaptureWorkflow.Broker 
            => CaptureBroker;

        ICaptureContext ICaptureWorkflow.Context
            => CWf.Context;            
    }    
}