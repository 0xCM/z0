//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface ICaptureEvents
    {
        WfStatus Status => default;

        IWfError Error => default(WfError<object>);

        CapturingHosts CapturingHosts => default;
        
        ExtractReportCreated ExtractReportCreated => default;

        ExtractedMembers ExtractedMembers => default;

        ExtractReportSaved ExtractReportSaved => default;

        FunctionsDecoded FunctionsDecoded => default;

        MembersLocated MembersLocated => default;

        ClearedDirectory ClearedDirectory => default;

        MatchedCapturedEmissions MatchedEmissions => default;

        CapturingPart CapturingPart => default;

        CapturedPart CapturedPart => default;

        CapturingHost CapturingHost => default;

        CapturedHost CapturedHost => default;

        HexCodeSaved HexSaved => default;

        ExtractParseFailed ExtractParseFailed => default;

        ExtractsParsed ExtractsParsed => default;
        
        EmittedParseReport ParseReportCreated => default;

        ClearedPartFiles ClearedPartFiles => default;                           
    }
}