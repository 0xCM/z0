//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface ICaptureWorkflow : IWorkflowStep<CaptureWorkflow>
    {
        ICaptureBroker Broker {get;}

        ICaptureContext Context {get;}

        void Run(AsmArchiveConfig config, params PartId[] parts)
            => ManageCapture.CaptureCatalogs(config, parts);        

        IMatchAddresses MatchAddresses 
            => new MatchAddressesStep(this);

        IManageCaptureStep ManageCapture
            => new ManageCaptureStep(this);

        IReportExtractsStep ReportExtracts
            => new EmitExtractReportStep(this);

        IEmitParsedReportStep ReportParsed
            => new EmitParsedReportStep(this);

        IExtractMembers ExtractMembers
            => new ExtractMembersStep(this);

        IDecodeStep DecodeParsed
            => new DecodedParsedStep(this);

        IParseMembers ParseMembers
            => new ParseMembersStep(this);

        IMatchEmissions MatchEmissions
            => new MatchEmissionsStep(this);
    }
}