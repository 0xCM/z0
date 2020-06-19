//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static HostCaptureSteps;

    public interface ICaptureHostStep : IWorkflowStep<CaptureHostStep>
    {
        void Execute(IApiHost host, ICaptureArchive dst);
    }

    public interface IDecodeStep : IWorkflowStep<DecodeStep>
    {
        AsmFunction[] DecodeParsed(ApiHostUri host, ParsedMember[] parsed);

        AsmFunction[] DecodeExtracts(params ParsedMember[] src);

        void SaveDecoded(AsmFunction[] src, FilePath dst);
    }    

    public interface IEmissionMatchStep : IWorkflowStep<EmissionMatchStep>
    {
        void MatchEmissions(ApiHostUri host, ReadOnlySpan<UriHex> srcA, FilePath srcB);
    }    

    public interface IManageCaptureStep : IWorkflowStep<ManageCaptureStep>
    {
        void CaptureCatalogs(AsmArchiveConfig config, params PartId[] parts);
        
        void CaptureCatalogs(ICaptureArchive dst, params PartId[] parts);

        void CaptureHost(ICaptureHostStep step, IApiHost host, ICaptureArchive dst);

        void CaptureCatalog(IApiCatalog src, ICaptureArchive dst);
    }    

    public interface IReportExtractsStep : IWorkflowStep<ReportExtractsStep>
    {
        ExtractReport CreateExtractReport(ApiHostUri host, ExtractedMember[] src);
        
        void SaveExtractReport(ExtractReport src, FilePath dst);
    }    

    public interface IExtractMembersStep : IWorkflowStep<ExtractMembersStep>
    {
        ApiMember[] LocateMembers(IApiHost host);

        ExtractedMember[] ExtractMembers(IApiHost host);
    }    

    public interface IAddressMatchStep : IWorkflowStep<AddressMatchStep>
    {
        void Run(ApiHostUri host, ExtractedMember[] extracted, AsmFunction[] decoded);
    }    

    public interface IParseMembersStep : IWorkflowStep<ParseMembersStep>
    {
        ParsedMember[] Parse(ApiHostUri host, ExtractedMember[] extracts);

        void SaveHex(ApiHostUri host, ParsedMember[] src, FilePath dst);
    }    

    public interface IEmitParsedReportStep : IWorkflowStep<EmitParsedReport>
    {
        void Emit(ApiHostUri host, ParsedMember[] src, FilePath dst);        
    }    
}