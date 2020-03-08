//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static Root;
    using static HostCaptureWorkflow;

    partial class HostCaptureWorkflow
    {
        public interface IWorkflowRunner : IAsmService, IAppEventSource
        {
            EventSinks ConnectSinks();

            void Run(FolderPath dst); 

            void Run(RootEmissionPaths root);            
        }

        public interface IHostCapture : IAsmService
        {

        }
    }
}