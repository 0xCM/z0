//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface ICaptureWorkflow : IServiceAllocation
    {
        ICaptureBroker Broker {get;}

        ICaptureContext Context {get;}

        IMatchAddresses MatchAddresses 
            => new MatchAddressesStep(this);

        ManageCaptureStep ManageCapture
            => new ManageCaptureStep(this);

        IReportExtractsStep ReportExtracts
            => new EmitExtractReportStep(this);

        IEmitParsedReportStep ReportParsed
            => new EmitParsedReportStep(this);

        ExtractMembersStep ExtractMembers
            => new ExtractMembersStep(this);

        IDecodeStep DecodeParsed
            => new DecodedParsedStep(this);

        IParseMembers ParseMembers
            => new ParseMembersStep(this);

        IMatchEmissions MatchEmissions
            => new MatchEmissionsStep(this);
        
        void Run(AsmArchiveConfig config, params PartId[] parts)
            => ManageCapture.CaptureParts(config, parts);        

        void RunConsoidated(AsmArchiveConfig config, params PartId[] parts)
            => ManageCapture.Consolidated(config, parts);        
    }
}