//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static AsmEvents;

    public interface IExtractReportRelay : IEventBroker<ExtractReportCreated>, IEventBroker<ExtractReportSaved>
    {
        ExtractReportCreated ExtractReportCreated => ExtractReportCreated.Empty;

        ExtractReportSaved ExtractReportSaved => ExtractReportSaved.Empty;        
    }
}