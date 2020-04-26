//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static AsmEvents;
    using static ExtractionEvents;

    sealed class ExtractionBroker : EventBroker<ExtractionBroker,IExtractionBroker>, IExtractionBroker
    {
        IExtractionBrokerClient Client => ExtractionBrokerClient.Create(this);
    }

    public interface IExtractionBroker : IStepBroker
    {
        HostMembersLocated MembersLocated => HostMembersLocated.Empty;

        HostMembersExtracted MembersExtracted => HostMembersExtracted.Empty;

        ExtractReportCreated ExtractReportCreated => ExtractReportCreated.Empty;

        ExtractReportSaved ExtractReportSaved => ExtractReportSaved.Empty;

        AnalyzingExtractReport AnalyzingExtractReport => AnalyzingExtractReport.Empty;
    }
}