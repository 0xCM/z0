//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static HostCaptureSteps;

    public interface ICaptureWorkflow : IWorkflowStep<CaptureWorkflow>
    {
        ICaptureBroker Broker {get;}

        ICaptureContext Context {get;}

        void Run(AsmArchiveConfig config, params PartId[] parts)
            => Manage.CaptureCatalogs(config, parts);        

        IAddressMatchStep MatchAddresses 
            => new AddressMatchStep(this);

        IManageCaptureStep Manage
            => new ManageCaptureStep(this);

        IReportExtractsStep ReportExtracts
            => new ReportExtractsStep(this);

        IEmitParsedReportStep ReportParsed
            => new EmitParsedReport(this);

        IExtractMembersStep Extract
            => new ExtractMembersStep(this);

        IDecodeStep Decode
            => new DecodeStep(this);

        IParseMembersStep Parse
            => new ParseMembersStep(this);

        IEmissionMatchStep MatchEmissions
            => new EmissionMatchStep(this);
    }
}