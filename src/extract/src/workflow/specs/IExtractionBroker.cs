//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Seed;
    using static AsmEvents;
    using static ExtractionEvents;

    public interface IExtractionBroker : IStepBroker
    {
        HostMembersLocated MembersLocated => HostMembersLocated.Empty;

        HostMembersExtracted MembersExtracted => HostMembersExtracted.Empty;

        ExtractReportCreated ExtractReportCreated => ExtractReportCreated.Empty;

        ExtractReportSaved ExtractReportSaved => ExtractReportSaved.Empty;

        AnalyzingExtractReport AnalyzingExtractReport => AnalyzingExtractReport.Empty;
    }
}