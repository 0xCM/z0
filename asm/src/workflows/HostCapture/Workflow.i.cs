//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static Root;
    using static HostCaptureWorkflow;
    using static AsmWorkflowReports;

    partial class HostCaptureWorkflow
    {

        public interface IHostCapture : IAsmService
        {

        }

        public interface IWorkflowEventBroker : IAppEventBroker
        {
            MembersLocated MembersLocated => MembersLocated.Empty;

            ExtractReportCreated ExtractReportCreated => ExtractReportCreated.Empty;

            ExtractsParsed ExtractsParsed => ExtractsParsed.Empty;
            
            ParseReportCreated ParseReportCreated => ParseReportCreated.Empty;

            FunctionsDecoded FunctionsDecoded => FunctionsDecoded.Empty;

            AsmCodeSaved CodeSaved => AsmCodeSaved.Empty;

            ExtractReportSaved HostReportSaved => ExtractReportSaved.Empty;

        }
        
        interface IWorkflowEventRelay : IWorkflowEventBroker, IAppEventRelay
        {

        }

        public interface IWorkflowRunner : IAsmService, IAppEventSource
        {
            IWorkflowEventBroker EventBroker {get;}

            void Run(FolderPath dst); 

            void Run(RootEmissionPaths root);      
        }
    }
}