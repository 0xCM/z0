//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
   public interface IHostCaptureBroker : 
        IStepBroker,
        IExtractReportBroker, 
        IMembersLocatedBroker, 
        IHostExtractParseBroker,
        IHostFunctionsDecodedBroker,
        ICatalogCaptureBroker,
        IHostHexSavedBroker,
        IImmEmissionBroker
    {
        
    }

    public interface IHostCaptureWorkflow
    {
        IHostCaptureBroker EventBroker {get;}

        void Run(AsmWorkflowConfig config, params PartId[] parts);         
    }


    public interface IReportExtractsStep
    {
        ExtractReport CreateExtractReport(ApiHostUri host, MemberExtract[] src);
        
        void SaveExtractReport(ExtractReport src, FilePath dst);
    }

    public interface IReportParsedStep
    {
        MemberParseReport CreateParseReport(ApiHostUri host, ParsedMember[] src);        

        void SaveParseReport(MemberParseReport src, FilePath dst);
    }

    public interface IExtractMembersStep
    {
        Member[] LocateMembers(IApiHost host);

        MemberExtract[] ExtractMembers(IApiHost host);
    }

    public interface IDecodeStep
    {
        AsmFunction[] DecodeParsed(ApiHostUri host, ParsedMember[] parsed);

        AsmFunction[] DecodeExtracts(params ParsedMember[] src);

        void SaveDecoded(AsmFunction[] src, FilePath dst);
    }

    public interface ICaptureHostStep
    {
        void Execute(IApiHost host, ICaptureArchive dst);
    }

    public interface ICaptureCatalogStep
    {
        void CaptureCatalogs(AsmWorkflowConfig config, params PartId[] parts);
        
        void CaptureCatalogs(ICaptureArchive dst, params PartId[] parts);

        void CaptureHost(ICaptureHostStep step, IApiHost host, ICaptureArchive dst);

        void CaptureCatalog(IApiCatalog src, ICaptureArchive dst);
    }
}