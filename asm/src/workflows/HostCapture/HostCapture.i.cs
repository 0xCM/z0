//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static Root;
    using static AsmWorkflowReports;
    
    partial class HostCaptureWorkflow
    {
        
 
        public interface IHostCaptureRunner :  IWorkflowRunner<IHostCaptureEventBroker, RootEmissionPaths>
        {
            void Run(FolderPath dst); 
        }

        public interface IHostCaptureWorkflow : IAsmWorkflow, IHostCaptureRunner
        {


        }
    }
}