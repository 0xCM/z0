//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static root;
    using static AsmWorkflowReports;    
    using static HostCaptureWorkflow;

    public interface IHostCaptureEventBroker : IWorkflowEventBroker
    {
        MembersLocated MembersLocated => MembersLocated.Empty;

        ExtractReportCreated ExtractReportCreated => ExtractReportCreated.Empty;

        ExtractsParsed ExtractsParsed => ExtractsParsed.Empty;            
        
        ParseReportCreated ParseReportCreated => ParseReportCreated.Empty;

        FunctionsDecoded FunctionsDecoded => FunctionsDecoded.Empty;
        
        AsmHexSaved HexSaved => AsmHexSaved.Empty;

        ExtractReportSaved HostReportSaved => ExtractReportSaved.Empty;

        StepStart<IApiCatalog> CaptureCatalogStart => StepStarted<IApiCatalog>();

        StepEnd<IApiCatalog> CaptureCatalogEnd => StepEnded<IApiCatalog>();

        StepStart<ApiHost> CaptureApiHostStart => StepStarted<ApiHost>();

        StepEnd<ApiHost> CaptureApiHostEnd => StepEnded<ApiHost>();
    }
}