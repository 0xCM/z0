//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IWfCaptureEvents
    {
        IWfStatus Status => default(WfStatus<string>);

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

        ApiHexTableSaved HexSaved => default;

        ExtractParseFailed ExtractParseFailed => default;

        ExtractsParsed ExtractsParsed => default;

        EmittedParseReport ParseReportCreated => default;

        ClearedPartFiles ClearedPartFiles => default;
    }
}