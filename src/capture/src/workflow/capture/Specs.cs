//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface ICaptureContext : IContext
    {
        IApiSet ApiSet {get;}

        IMemberExtractor Extractor {get;}

        IExtractParser Parser {get;}

        IAsmFunctionDecoder Decoder {get;}

        IAsmFormatter Formatter {get;}

        AsmWriterFactory WriterFactory {get;}

        ICaptureBroker Broker {get;}

        ICaptureArchive Archive {get;}

        IAppMsgSink MsgSink {get;}

        ref readonly E Raise<E>(in E e)
            where E : IAppEvent;

        CorrelationToken Correlate();                    
    }

   public interface ICaptureBroker : 
        ICatalogCaptureBroker,
        IExtractReportBroker, 
        IMembersLocatedBroker, 
        IExtractParseBroker,
        IFunctionsDecodedBroker,
        IHexSavedBroker,
        IImmEmissionBroker
    {
        
    }

    public interface ICaptureClient : 
        ICatalogCaptureClient<ICaptureBroker>,
        IExtractReportClient<ICaptureBroker>,
        IMembersLocatedClient<ICaptureBroker>,
        IExtractParseClient<ICaptureBroker>,
        IFunctionsDecodedClient<ICaptureBroker>,
        IHexSavedClient<ICaptureBroker>
    {
        void OnEvent(AppErrorEvent e) 
        {
            Sink.Deposit(e);
        }

        void Connect()
        {
            Broker.Error.Subscribe(Broker,OnEvent);
            Broker.CaptureCatalogStart.Subscribe(Broker,OnEvent);
            Broker.CaptureCatalogEnd.Subscribe(Broker,OnEvent);
            Broker.MembersLocated.Subscribe(Broker,OnEvent);
            Broker.ExtractReportCreated.Subscribe(Broker,OnEvent);
            Broker.ExtractReportSaved.Subscribe(Broker,OnEvent);
            Broker.ParseReportCreated.Subscribe(Broker, OnEvent);
            Broker.FunctionsDecoded.Subscribe(Broker, OnEvent);
            Broker.HexSaved.Subscribe(Broker,OnEvent);
            Broker.ExtractsParsed.Subscribe(Broker,OnEvent);
            Broker.ExtractParseFailed.Subscribe(Broker,OnEvent);
            Broker.MatchedEmissions.Subscribe(Broker, OnEvent);
            Broker.PurgedArchiveFolder.Subscribe(Broker, OnEvent);
        }        

    }

    public interface IWorkflowStep<C> : IService<C>
        where C : IContext
    {

    }

    public interface ICaptureStep : IWorkflowStep<ICaptureContext>
    {

    }

    public interface ICaptureSteps : ICaptureStep
    {
        IManageCaptureStep Manage {get;}

        IExtractMembersStep Extract {get;}

        IDecodeStep Decode {get;}

        IParseMembersStep Parse {get;}

        IEmissionMatchStep MatchEmissions {get;}                    

        IReportParsedStep ReportParsed {get;}        

        IReportExtractsStep ReportExtracts {get;}
    }

    public interface ICaptureWorkflow : ICaptureSteps
    {
        ICaptureBroker Broker {get;}

        void Run(AsmArchiveConfig config, params PartId[] parts);         
    }

    public interface ICaptureHost : IExecutable<PartId>, IDisposable, ICaptureClient
    {
        
    }

    public interface IParseMembersStep : ICaptureStep
    {
        ParsedMember[] ParseExtracts(ApiHostUri host, ExtractedMember[] extracts);

        void SaveHex(ApiHostUri host, ParsedMember[] src, FilePath dst);
    }

    public interface IReportExtractsStep : ICaptureStep
    {
        ExtractReport CreateExtractReport(ApiHostUri host, ExtractedMember[] src);
        
        void SaveExtractReport(ExtractReport src, FilePath dst);
    }

    public interface IReportParsedStep : ICaptureStep
    {
        MemberParseReport CreateParseReport(ApiHostUri host, ParsedMember[] src);        

        void SaveParseReport(MemberParseReport src, FilePath dst);
    }

    public interface IExtractMembersStep : ICaptureStep
    {
        ApiMember[] LocateMembers(IApiHost host);

        ExtractedMember[] ExtractMembers(IApiHost host);
    }

    public interface IDecodeStep : ICaptureStep
    {
        AsmFunction[] DecodeParsed(ApiHostUri host, ParsedMember[] parsed);

        AsmFunction[] DecodeExtracts(params ParsedMember[] src);

        void SaveDecoded(AsmFunction[] src, FilePath dst);
    }

    public interface ICaptureHostStep : ICaptureStep
    {
        void Execute(IApiHost host, ICaptureArchive dst);

    }

    public interface IEmissionMatchStep : ICaptureStep
    {
        void MatchEmissions(ApiHostUri host, ReadOnlySpan<UriHex> srcA, FilePath srcB);
    }

    public interface IManageCaptureStep : ICaptureStep
    {
        void CaptureCatalogs(AsmArchiveConfig config, params PartId[] parts);
        
        void CaptureCatalogs(ICaptureArchive dst, params PartId[] parts);

        void CaptureHost(ICaptureHostStep step, IApiHost host, ICaptureArchive dst);

        void CaptureCatalog(IApiCatalog src, ICaptureArchive dst);
    }
}