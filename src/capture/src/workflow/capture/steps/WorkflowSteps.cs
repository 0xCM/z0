//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IImmEmissionWorkflow : IWorkflow<IImmEmissionBroker>, IServiceAllocation
    {
        void EmitLiteral(byte[] imm8, params PartId[] parts);

        void EmitRefined(params PartId[] parts);

        void ClearArchive(params PartId[] parts);        
    }

    public interface ICaptureHostStep
    {
        void Execute(IApiHost host, TPartCaptureArchive dst);
    }

    public interface IDecodeStep
    {
        AsmFunction[] DecodeParsed(ApiHostUri host, ParsedExtract[] parsed);

        void SaveDecoded(AsmFunction[] src, FilePath dst);
    }    

    public interface IMatchEmissions
    {
        void MatchEmissions(ApiHostUri host, ReadOnlySpan<IdentifiedCode> srcA, FilePath srcB);
    }    

    public interface IManageCaptureStep
    {
        void CaptureHost(CaptureHostStep step, IApiHost host, TPartCaptureArchive dst);

        void CaptureParts(AsmArchiveConfig config, params PartId[] parts);
        
        void CapturePart(IPartCatalog src, TPartCaptureArchive dst);
    }    

    public interface IReportExtractsStep 
    {
        ExtractReport CreateExtractReport(ApiHostUri host, ExtractedCode[] src);
        
        void SaveExtractReport(ExtractReport src, FilePath dst);
    }    

    public interface IExtractMembers
    {
        ExtractedCode[] ExtractMembers(IApiHost host);
    }    

    public interface IMatchAddresses
    {
        void Run(ApiHostUri host, ExtractedCode[] extracted, AsmFunction[] decoded);
    }    

    public interface IParseMembers
    {
        ParsedExtract[] Parse(ApiHostUri host, ExtractedCode[] extracts);

        void SaveHex(ApiHostUri host, ParsedExtract[] src, FilePath dst);
    }    

    public interface IEmitParsedReportStep
    {
        void Emit(ApiHostUri host, ParsedExtract[] src, FilePath dst);        
    }    
}