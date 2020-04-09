//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    public interface IExtractReportRelay : IWorkflowRelay
    {
        ExtractReportCreated ExtractReportCreated => ExtractReportCreated.Empty;

        ExtractReportSaved ExtractReportSaved => ExtractReportSaved.Empty;        
    }

    public interface IMemberLocationRelay : IWorkflowRelay
    {
        HostMembersLocated MembersLocated => HostMembersLocated.Empty;
    }

    public interface IHostExtractParseRelay : IWorkflowRelay
    {
        HostExtractsParsed ExtractsParsed => HostExtractsParsed.Empty;            
        
        ParseReportCreated ParseReportCreated => ParseReportCreated.Empty;
    }

    public interface IHostFunctionsDecodedRelay : IWorkflowRelay
    {
        HostFunctionsDecoded FunctionsDecoded => HostFunctionsDecoded.Empty;
    }

    public interface ICatalogCaptureRelay : IWorkflowRelay
    {
        StepStart<IApiCatalog> CaptureCatalogStart => StepStarted<IApiCatalog>();

        StepEnd<IApiCatalog> CaptureCatalogEnd => StepEnded<IApiCatalog>();
    }

    public interface IHostHexSavedRelay : IWorkflowRelay
    {
        HostAsmHexSaved HexSaved => HostAsmHexSaved.Empty;        
    }

    public interface IHostCaptureRelay : IWorkflowRelay
    {
        StepStart<ApiHost> CaptureApiHostStart => StepStarted<ApiHost>();

        StepEnd<ApiHost> CaptureApiHostEnd => StepEnded<ApiHost>();

    }

}