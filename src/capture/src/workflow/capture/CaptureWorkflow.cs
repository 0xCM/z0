//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static HostCaptureSteps;
        
    public readonly struct CaptureWorkflow : ICaptureWorkflow
    {
        public ICaptureContext Context {get;}

        public ICaptureBroker EventBroker {get;}
        
        [MethodImpl(Inline)]
        internal CaptureWorkflow(IAsmContext context, IAsmFunctionDecoder decoder, IAsmFormatter formatter, AsmWriterFactory writerfactory, ICaptureArchive archive)
        {
            EventBroker = HostCaptureBroker.New;
            Context = new CaptureWorkflowContext(context, decoder, formatter, writerfactory, EventBroker, archive);
        }
 
        public void Run(AsmWorkflowConfig config, params PartId[] parts) 
        {
            Manage.CaptureCatalogs(config, parts);
        }

        public IManageCaptureStep Manage
            => new ManageCaptureStep(this);

        public IReportExtractsStep ReportExtracts
            => new ReportExtractsStep(this);

        public IReportParsedStep ReportParsed
            => new ReportParsedStep(this);

        public IExtractMembersStep Extract
            => new ExtractMembersStep(this);

        public IDecodeStep Decode
            => new DecodeStep(this);

        public IParseMembersStep Parse
            => new ParseMembersStep(this);

        public IEmissionMatchStep MatchEmissions
            => new EmissionMatchStep(this);
    }
}