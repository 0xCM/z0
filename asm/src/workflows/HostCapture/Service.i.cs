//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static Root;
    
    partial class HostCaptureWorkflow
    {
        public interface IWorkflowService : IAsmService
        {
            void ExecuteWorkflow(FolderPath dst); 

            EventSinks ConnectSinks();
            
        }
    }
}