//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface ICaptureHostStep : IWorkflowStep<CaptureHostStep>
    {
        void Execute(IApiHost host, ICaptureArchive dst);
    }

    public interface IDecodeStep : IWorkflowStep<DecodedParsedStep>
    {
        AsmFunction[] DecodeParsed(ApiHostUri host, ParsedExtract[] parsed);

        void SaveDecoded(AsmFunction[] src, FilePath dst);
    }    

    public interface IMatchEmissions : IWorkflowStep<MatchEmissionsStep>
    {
        void MatchEmissions(ApiHostUri host, ReadOnlySpan<IdentifiedCode> srcA, FilePath srcB);
    }    

    public interface IManageCaptureStep : IWorkflowStep<ManageCaptureStep>
    {
        void CaptureCatalogs(AsmArchiveConfig config, params PartId[] parts);
        
        void CaptureCatalogs(ICaptureArchive dst, params PartId[] parts);

        void CaptureHost(ICaptureHostStep step, IApiHost host, ICaptureArchive dst);

        void CaptureCatalog(IApiCatalog src, ICaptureArchive dst);
    }    

    public interface IReportExtractsStep : IWorkflowStep<EmitExtractReportStep>
    {
        ExtractReport CreateExtractReport(ApiHostUri host, ExtractedCode[] src);
        
        void SaveExtractReport(ExtractReport src, FilePath dst);
    }    

    public interface IExtractMembers : IWorkflowStep<ExtractMembersStep>
    {
        ApiMember[] LocateMembers(IApiHost host);

        ExtractedCode[] ExtractMembers(IApiHost host);
    }    

    public interface IMatchAddresses : IWorkflowStep<MatchAddressesStep>
    {
        void Run(ApiHostUri host, ExtractedCode[] extracted, AsmFunction[] decoded);
    }    

    public interface IParseMembers : IWorkflowStep<ParseMembersStep>
    {
        ParsedExtract[] Parse(ApiHostUri host, ExtractedCode[] extracts);

        void SaveHex(ApiHostUri host, ParsedExtract[] src, FilePath dst);
    }    

    public interface IEmitParsedReportStep : IWorkflowStep<EmitParsedReportStep>
    {
        void Emit(ApiHostUri host, ParsedExtract[] src, FilePath dst);        
    }    
}