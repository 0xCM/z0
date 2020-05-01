//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static CaptureWorkflowEvents;
    using static ExtractionEvents;

    sealed class ExtractionBroker : EventBroker<ExtractionBroker,IExtractionBroker>, IExtractionBroker
    {
        //IExtractionBrokerClient Client => ExtractionBrokerClient.Create(this);
    }

    public interface IExtractionBroker : IStepBroker
    {
        MembersLocated MembersLocated => MembersLocated.Empty;

        MembersExtracted MembersExtracted => MembersExtracted.Empty;

        ExtractReportCreated ExtractReportCreated => ExtractReportCreated.Empty;

        ExtractReportSaved ExtractReportSaved => ExtractReportSaved.Empty;

        AnalyzingExtractReport AnalyzingExtractReport => AnalyzingExtractReport.Empty;
    }
}